using Requests.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests.Api
{
    public class ApiClass : IDisposable
    {
        /// # -*- coding: utf-8 -*-
        /// 
        /// """
        /// requests.api
        /// ~~~~~~~~~~~~
        /// 
        /// This module implements the Requests API.
        /// 
        /// :copyright: (c) 2012 by Kenneth Reitz.
        /// :license: Apache2, see LICENSE for more details.
        /// 
        /// """
        /// 
        /// from . import sessions
        /// 
        /// 
        /// def request(method, url, **kwargs):
        ///     """Constructs and sends a :class:`Request <Request>`.
        /// 
        ///     :param method: method for the new :class:`Request` object.
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param params: (optional) Dictionary or bytes to be sent in the query string for the :class:`Request`.
        ///     :param data: (optional) Dictionary, bytes, or file-like object to send in the body of the :class:`Request`.
        ///     :param json: (optional) json data to send in the body of the :class:`Request`.
        ///     :param headers: (optional) Dictionary of HTTP Headers to send with the :class:`Request`.
        ///     :param cookies: (optional) Dict or CookieJar object to send with the :class:`Request`.
        ///     :param files: (optional) Dictionary of ``'name': file-like-objects`` (or ``{'name': ('filename', fileobj)}``) for multipart encoding upload.
        ///     :param auth: (optional) Auth tuple to enable Basic/Digest/Custom HTTP Auth.
        ///     :param timeout: (optional) How long to wait for the server to send data
        ///         before giving up, as a float, or a :ref:`(connect timeout, read
        ///         timeout) <timeouts>` tuple.
        ///     :type timeout: float or tuple
        ///     :param allow_redirects: (optional) Boolean. Set to True if POST/PUT/DELETE redirect following is allowed.
        ///     :type allow_redirects: bool
        ///     :param proxies: (optional) Dictionary mapping protocol to the URL of the proxy.
        ///     :param verify: (optional) whether the SSL cert will be verified. A CA_BUNDLE path can also be provided. Defaults to ``True``.
        ///     :param stream: (optional) if ``False``, the response content will be immediately downloaded.
        ///     :param cert: (optional) if String, path to ssl client cert file (.pem). If Tuple, ('cert', 'key') pair.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        /// 
        ///     Usage::
        /// 
        ///       >>> import requests
        ///       >>> req = requests.request('GET', 'http://httpbin.org/get')
        ///       <Response [200]>
        ///     """
        /// 
        ///     # By using the 'with' statement we are sure the session is closed, thus we
        ///     # avoid leaving sockets open which can trigger a ResourceWarning in some
        ///     # cases, and look like a memory leak in others.
        ///     with sessions.Session() as session:
        ///         return session.request(method=method, url=url, **kwargs)
        public void Request(string Method, string URL)
        {
            using (var session = new Session())
                session.Request(Method, URL);
        }
        /// 
        /// 
        /// def get(url, params=None, **kwargs):
        ///     """Sends a GET request.
        /// 
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param params: (optional) Dictionary or bytes to be sent in the query string for the :class:`Request`.
        ///     :param \*\*kwargs: Optional arguments that ``request`` takes.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        ///     """
        /// 
        ///     kwargs.setdefault('allow_redirects', True)
        ///     return request('get', url, params=params, **kwargs)
        // TODO: API.Get()
        public void Get(string URL)
        {

        }
        /// 
        /// 
        /// def options(url, **kwargs):
        ///     """Sends a OPTIONS request.
        /// 
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param \*\*kwargs: Optional arguments that ``request`` takes.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        ///     """
        /// 
        ///     kwargs.setdefault('allow_redirects', True)
        ///     return request('options', url, **kwargs)
        /// 
        /// 
        /// def head(url, **kwargs):
        ///     """Sends a HEAD request.
        /// 
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param \*\*kwargs: Optional arguments that ``request`` takes.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        ///     """
        /// 
        ///     kwargs.setdefault('allow_redirects', False)
        ///     return request('head', url, **kwargs)
        /// 
        /// 
        /// def post(url, data=None, json=None, **kwargs):
        ///     """Sends a POST request.
        /// 
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param data: (optional) Dictionary, bytes, or file-like object to send in the body of the :class:`Request`.
        ///     :param json: (optional) json data to send in the body of the :class:`Request`.
        ///     :param \*\*kwargs: Optional arguments that ``request`` takes.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        ///     """
        /// 
        ///     return request('post', url, data=data, json=json, **kwargs)
        /// 
        /// 
        /// def put(url, data=None, **kwargs):
        ///     """Sends a PUT request.
        /// 
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param data: (optional) Dictionary, bytes, or file-like object to send in the body of the :class:`Request`.
        ///     :param \*\*kwargs: Optional arguments that ``request`` takes.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        ///     """
        /// 
        ///     return request('put', url, data=data, **kwargs)
        /// 
        /// 
        /// def patch(url, data=None, **kwargs):
        ///     """Sends a PATCH request.
        /// 
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param data: (optional) Dictionary, bytes, or file-like object to send in the body of the :class:`Request`.
        ///     :param \*\*kwargs: Optional arguments that ``request`` takes.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        ///     """
        /// 
        ///     return request('patch', url,  data=data, **kwargs)
        /// 
        /// 
        /// def delete(url, **kwargs):
        ///     """Sends a DELETE request.
        /// 
        ///     :param url: URL for the new :class:`Request` object.
        ///     :param \*\*kwargs: Optional arguments that ``request`` takes.
        ///     :return: :class:`Response <Response>` object
        ///     :rtype: requests.Response
        ///     """
        /// 
        ///     return request('delete', url, **kwargs)
        
        #region IDisposable Support
        private bool disposedValue = false; // 중복 호출을 검색하려면

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 관리되는 상태(관리되는 개체)를 삭제합니다.
                }

                // TODO: 관리되지 않는 리소스(관리되지 않는 개체)를 해제하고 아래의 종료자를 재정의합니다.
                // TODO: 큰 필드를 null로 설정합니다.

                disposedValue = true;
            }
        }

        // TODO: 위의 Dispose(bool disposing)에 관리되지 않는 리소스를 해제하는 코드가 포함되어 있는 경우에만 종료자를 재정의합니다.
        // ~API() {
        //   // 이 코드를 변경하지 마세요. 위의 Dispose(bool disposing)에 정리 코드를 입력하세요.
        //   Dispose(false);
        // }

        // 삭제 가능한 패턴을 올바르게 구현하기 위해 추가된 코드입니다.
        void IDisposable.Dispose()
        {
            // 이 코드를 변경하지 마세요. 위의 Dispose(bool disposing)에 정리 코드를 입력하세요.
            Dispose(true);
            // TODO: 위의 종료자가 재정의된 경우 다음 코드 줄의 주석 처리를 제거합니다.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
