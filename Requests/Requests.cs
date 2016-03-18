using Requests.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests
{
    public class Requests : IDisposable
    {
        /// # -*- coding: utf-8 -*-
        /// 
        /// #   __
        /// #  /__)  _  _     _   _ _/   _
        /// # / (   (- (/ (/ (- _)  /  _)
        /// #          /
        /// 
        /// """
        /// Requests HTTP library
        /// ~~~~~~~~~~~~~~~~~~~~~
        /// 
        /// Requests is an HTTP library, written in Python, for human beings. Basic GET
        /// usage:
        /// 
        ///    >>> import requests
        ///    >>> r = requests.get('https://www.python.org')
        ///    >>> r.status_code
        ///    200
        ///    >>> 'Python is a programming language' in r.content
        ///    True
        /// 
        /// ... or POST:
        /// 
        ///    >>> payload = dict(key1='value1', key2='value2')
        ///    >>> r = requests.post('http://httpbin.org/post', data=payload)
        ///    >>> print(r.text)
        ///    {
        ///      ...
        ///      "form": {
        ///        "key2": "value2",
        ///        "key1": "value1"
        ///      },
        ///      ...
        ///    }
        /// 
        /// The other HTTP methods are supported - see `requests.api`. Full documentation
        /// is at <http://python-requests.org>.
        /// 
        /// :copyright: (c) 2015 by Kenneth Reitz.
        /// :license: Apache 2.0, see LICENSE for more details.
        /// 
        /// """
        /// 
        /// __title__ = 'requests'
        /// __version__ = '2.9.1'
        /// __build__ = 0x020901
        /// __author__ = 'Kenneth Reitz'
        /// __license__ = 'Apache 2.0'
        /// __copyright__ = 'Copyright 2016 Kenneth Reitz'
        public const string Title = "requests";
        public const string Version = "2.9.1";
        public const int Build = 0x020901;
        public const string Author = "Kenneth Reitz";
        public const string Contributor = "R";
        public const string License = "Apache 2.0";
        public const string Copyright = "Copyright 2016 Kenneth Reitz";
        /// 
        /// # Attempt to enable urllib3's SNI support, if possible
        /// try:
        ///     from .packages.urllib3.contrib import pyopenssl
        ///     pyopenssl.inject_into_urllib3()
        /// except ImportError:
        ///     pass
        /// 
        /// from . import utils
        /// from .models import Request, Response, PreparedRequest
        /// from .api import request, get, head, post, patch, put, delete, options
        // TODO: Requests.Request()
        public void Request() { }
        public void Get(string URL) { using (var api = new ApiClass()) { api.Get(URL); } }
        /// from .sessions import session, Session
        /// from .status_codes import codes
        /// from .exceptions import (
        ///     RequestException, Timeout, URLRequired,
        ///     TooManyRedirects, HTTPError, ConnectionError,
        ///     FileModeWarning, ConnectTimeout, ReadTimeout
        /// )
        /// 
        /// # Set default logging handler to avoid "No handler found" warnings.
        /// import logging
        /// try:  # Python 2.7+
        ///     from logging import NullHandler
        /// except ImportError:
        ///     class NullHandler(logging.Handler):
        ///         def emit(self, record):
        ///             pass
        /// 
        /// logging.getLogger(__name__).addHandler(NullHandler())
        /// 
        /// import warnings
        /// 
        /// # FileModeWarnings go off per the default.
        /// warnings.simplefilter('default', FileModeWarning, append=True)


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
        // ~Requests() {
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
