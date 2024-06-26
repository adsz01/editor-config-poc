using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;

namespace SB.Customer.Management.Infrastructure.API.Client
{
    public class UrlPathBuilder
    {
        private readonly StringBuilder _pathBuilder;
        private NameValueCollection _queryString;

        public UrlPathBuilder()
        {
            _pathBuilder = new StringBuilder();
            _queryString = new NameValueCollection();
        }

        public UrlPathBuilder(Uri uri) : this()
        {
            Scheme = uri?.Scheme;
            Host = uri?.Host;
            Append(uri?.AbsolutePath);
            Port = uri?.Port ?? 80;
        }

        public string Scheme { get; set; }

        public int Length
        {
            get => _pathBuilder.Length;
            set => _pathBuilder.Length = value;
        }

        public string Host { get; set; }
        public int Port { get; set; }

        public string QueryString
        {
            get
            {
                if (_queryString.Count == 0)
                {
                    return string.Empty;
                }

                var array = (
                    from key in _queryString.AllKeys
                    from value in _queryString.GetValues(key)
                    select $"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(value)}"
                ).ToArray();
                return "?" + string.Join("&", array);
            }
            set => _queryString = HttpUtility.ParseQueryString(value);
        }

        public UrlPathBuilder Append(string part)
        {
            if (string.IsNullOrWhiteSpace(part) || part == "/")
            {
                return this;
            }

            _pathBuilder.Append('/').Append(part.Trim('/'));
            return this;
        }

        public UrlPathBuilder AddQueryParameter(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(name) || value == null)
            {
                return this;
            }

            _queryString.Add(name, value);
            return this;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append(string.IsNullOrWhiteSpace(Scheme) ? "http" : Scheme).Append("://");

            builder.Append((Host ?? "localhost").TrimEnd('/'));
            if (Port != 80)
            {
                builder.Append(":").Append(Port);
            }

            var path = $"{_pathBuilder.ToString().Trim('/')}";

            if (!string.IsNullOrWhiteSpace(path))
            {
                builder.Append("/").Append(path);
            }

            if (!string.IsNullOrWhiteSpace(QueryString))
            {
                builder.Append(QueryString);
            }

            return builder.ToString();
        }

        public UrlPathBuilder Replace(string commandname, string escapeDataString)
        {
            _pathBuilder.Replace(commandname, escapeDataString);
            return this;
        }
    }
}