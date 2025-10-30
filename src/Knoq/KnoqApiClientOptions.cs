using System;
using System.Diagnostics.CodeAnalysis;

namespace Knoq
{
    /// <summary>
    /// Represents a preference of authentication method for the knoQ API.
    /// </summary>
    public enum KnoqAuthMethodPreference
    {
        /// <summary>
        /// Preference is not specified.
        /// </summary>
        NotSpecified = 0,

        /// <summary>
        /// Prefer cookie authentication.
        /// </summary>
        PreferCookieAuth
    }

    /// <summary>
    /// Represents read-only options for the default service that implements the <see cref="KnoqApiClient"/> interface.
    /// </summary>
    public interface IReadOnlyKnoqApiClientOptions
    {
        /// <summary>
        /// Gets the preference of authentication method for the knoQ API.
        /// </summary>
        /// <returns>The preference of authentication method for the knoQ API.</returns>
        public abstract KnoqAuthMethodPreference AuthMethodPreference { get; }

        /// <summary>
        /// Gets the base address of the knoQ API.
        /// </summary>
        /// <returns>
        /// The base address of the knoQ API.
        /// </returns>
        public abstract string BaseAddress { get; }

        /// <summary>
        /// Gets the token used in cookie authentication to access the knoQ API.
        /// </summary>
        /// <returns>The token used in cookie authentication to access the knoQ API.</returns>
        public string? CookieAuthToken { get; }
    }

    /// <summary>
    /// Options for the default service that implements the <see cref="IReadOnlyKnoqApiClientOptions"/> interface.
    /// </summary>
    public sealed class KnoqApiClientOptions : IReadOnlyKnoqApiClientOptions
    {
        /// <summary>
        /// Gets or sets the preference of authentication method for the knoQ API.
        /// </summary>
        /// <remarks>
        /// If the value is set to <see cref="KnoqAuthMethodPreference.NotSpecified"/>, this method tries to use bearer authentication in preference.
        /// </remarks>
        /// <value>The preference of authentication method for the knoQ API.</value>
        public KnoqAuthMethodPreference AuthMethodPreference { get; set; } = KnoqAuthMethodPreference.NotSpecified;

        /// <summary>
        /// Gets or sets the base address of the knoQ API.
        /// </summary>
        /// <value>
        /// The base address of the knoQ API.
        /// </value>
        /// <exception cref="UriFormatException"></exception>
        public string BaseAddress
        {
            get => _baseAddressString;

            set
            {
                if (value == _baseAddressString)
                {
                    return;
                }
                _baseAddressUriCached = null;
                if (string.IsNullOrWhiteSpace(value))
                {
                    _baseAddressString = string.Empty;
                }
                else
                {
                    var address = value.AsSpan().Trim();
                    _baseAddressString = (address[^1] == '/')
                        ? ((value.Length == address.Length) ? value : address.ToString())
                        : $"{address}/";

                    if (!Uri.IsWellFormedUriString(_baseAddressString, UriKind.Absolute))
                    {
                        ThrowHelper.ThrowUriFormatException("The provided base address is not a valid absolute URI.");
                    }
                }
            }
        }
        string _baseAddressString = string.Empty;

        /// <summary>
        /// Gets the base address of the knoQ API as an instance of the <see cref="Uri"/> class.
        /// </summary>
        /// <returns>The base address of the knoQ API. The value is <see langword="null"/> when <see cref="BaseAddress"/> is null, empty or consists of only white-space characters.</returns>
        public Uri? BaseAddressUri
        {
            get
            {
                if (_baseAddressString == string.Empty)
                {
                    return null;
                }
                else if (_baseAddressUriCached is not null)
                {
                    return _baseAddressUriCached;
                }
                return _baseAddressUriCached = new Uri(_baseAddressString, UriKind.Absolute);
            }
        }
        Uri? _baseAddressUriCached = null;

        /// <summary>
        /// Gets or sets the token used in cookie authentication to access the knoQ API.
        /// </summary>
        /// <value>The token used in cookie authentication to access the knoQ API.</value>
        public string? CookieAuthToken { get; set; } = null;
    }

    file static class ThrowHelper
    {
        [DoesNotReturn]
        public static void ThrowUriFormatException(string message)
        {
            throw new UriFormatException(message);
        }
    }
}
