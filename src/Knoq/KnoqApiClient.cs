using Microsoft.Extensions.Options;
using System;
using System.Net.Http;

namespace Knoq
{
    /// <summary>
    /// Represents a client used to access the knoQ API.
    /// </summary>
    public interface IKnoqApiClient : IDisposable
    {
        /// <summary>
        /// Gets the <see cref="HttpClient"/> for API access.
        /// </summary>
        public HttpClient Client { get; }

        /// <summary>
        /// Gets the <see cref="HttpClientHandler"/> used by the <see cref="Client"/>.
        /// </summary>
        public HttpClientHandler? ClientHandler { get; }

        /// <summary>
        /// Gets the options for this client.
        /// </summary>
        public IReadOnlyKnoqApiClientOptions Options { get; }

        /// <summary>
        /// Gets the client for Activity API.
        /// </summary>
        public Api.IActivityApi ActivityApi { get; }

        /// <summary>
        /// Gets the client for Authentication API.
        /// </summary>
        public Api.IAuthenticationApi AuthenticationApi { get; }

        /// <summary>
        /// Gets the client for Events API.
        /// </summary>
        public Api.IEventsApi EventsApi { get; }

        /// <summary>
        /// Gets the client for Groups API.
        /// </summary>
        public Api.IGroupsApi GroupsApi { get; }

        /// <summary>
        /// Gets the client for ICal API.
        /// </summary>
        public Api.IICalApi ICalApi { get; }

        /// <summary>
        /// Gets the client for Public API.
        /// </summary>
        public Api.IPublicApi PublicApi { get; }

        /// <summary>
        /// Gets the client for Rooms API.
        /// </summary>
        public Api.IRoomsApi RoomsApi { get; }

        /// <summary>
        /// Gets the client for Tags API.
        /// </summary>
        public Api.ITagsApi TagsApi { get; }

        /// <summary>
        /// Gets the client for Users API.
        /// </summary>
        public Api.IUsersApi UsersApi { get; }
    }

    /// <summary>
    /// Represents a client used to access the knoQ API.
    /// </summary>
    public sealed class KnoqApiClient : IKnoqApiClient
    {
        readonly KnoqApiClientOptions _options;

        /// <inheritdoc/>
        public HttpClient Client { get; }

        /// <inheritdoc/>
        public HttpClientHandler? ClientHandler { get; }

        /// <inheritdoc/>
        public IReadOnlyKnoqApiClientOptions Options => _options;

        #region Lazy initialized APIs

        readonly Lazy<Api.ActivityApi> _activityApi;
        readonly Lazy<Api.AuthenticationApi> _authenticationApi;
        readonly Lazy<Api.EventsApi> _eventsApi;
        readonly Lazy<Api.GroupsApi> _groupsApi;
        readonly Lazy<Api.ICalApi> _iCalApi;
        readonly Lazy<Api.PublicApi> _publicApi;
        readonly Lazy<Api.RoomsApi> _roomsApi;
        readonly Lazy<Api.TagsApi> _tagsApi;
        readonly Lazy<Api.UsersApi> _usersApi;

        #endregion

        #region APIs

        /// <inheritdoc cref="IKnoqApiClient.ActivityApi"/>
        public Api.ActivityApi ActivityApi => _activityApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.AuthenticationApi"/>
        public Api.AuthenticationApi AuthenticationApi => _authenticationApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.EventsApi"/>
        public Api.EventsApi EventsApi => _eventsApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.GroupsApi"/>
        public Api.GroupsApi GroupsApi => _groupsApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.ICalApi"/>
        public Api.ICalApi ICalApi => _iCalApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.PublicApi"/>
        public Api.PublicApi PublicApi => _publicApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.RoomsApi"/>
        public Api.RoomsApi RoomsApi => _roomsApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.TagsApi"/>
        public Api.TagsApi TagsApi => _tagsApi.Value;

        /// <inheritdoc cref="IKnoqApiClient.UsersApi"/>
        public Api.UsersApi UsersApi => _usersApi.Value;

        Api.IActivityApi IKnoqApiClient.ActivityApi => ActivityApi;
        Api.IAuthenticationApi IKnoqApiClient.AuthenticationApi => AuthenticationApi;
        Api.IEventsApi IKnoqApiClient.EventsApi => EventsApi;
        Api.IGroupsApi IKnoqApiClient.GroupsApi => GroupsApi;
        Api.IICalApi IKnoqApiClient.ICalApi => ICalApi;
        Api.IPublicApi IKnoqApiClient.PublicApi => PublicApi;
        Api.IRoomsApi IKnoqApiClient.RoomsApi => RoomsApi;
        Api.ITagsApi IKnoqApiClient.TagsApi => TagsApi;
        Api.IUsersApi IKnoqApiClient.UsersApi => UsersApi;

        #endregion

        /// <summary>
        /// Initialize a new instance of the <see cref="KnoqApiClient"/> class with configurated options for the instance.
        /// </summary>
        /// <param name="options"></param>
        public KnoqApiClient(IOptions<KnoqApiClientOptions> options)
        {
            var o = options.Value;
            var (client, clientHandler) = CreateHttpClient(o);

            Client = client;
            ClientHandler = clientHandler;
            _options = o;

            _activityApi = new(() => new(client, clientHandler));
            _authenticationApi = new(() => new(client, clientHandler));
            _eventsApi = new(() => new(client, clientHandler));
            _groupsApi = new(() => new(client, clientHandler));
            _iCalApi = new(() => new(client, clientHandler));
            _publicApi = new(() => new(client, clientHandler));
            _roomsApi = new(() => new(client, clientHandler));
            _tagsApi = new(() => new(client, clientHandler));
            _usersApi = new(() => new(client, clientHandler));
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            Client?.Dispose();
            ClientHandler?.Dispose();
        }

        static (HttpClient, HttpClientHandler) CreateHttpClient(KnoqApiClientOptions options)
        {
            HttpClientHandler handler = new();
            HttpClient client = new(handler);

            if (options.BaseAddress is null)
            {
                throw new ArgumentException("Base address must be set.", nameof(options));
            }

            if (options.CookieAuthToken is not null)
            {
                configureCookie(options, handler);
            }

            return (client, handler);

            static void configureCookie(KnoqApiClientOptions o, HttpClientHandler h)
            {
                h.CookieContainer.Add(new System.Net.Cookie()
                {
                    Domain = o.BaseAddressUri.Host,
                    HttpOnly = true,
                    Name = "session",
                    Path = "/",
                    Secure = o.BaseAddressUri.Scheme == Uri.UriSchemeHttps,
                    Value = o.CookieAuthToken,
                });
            }
        }
    }
}
