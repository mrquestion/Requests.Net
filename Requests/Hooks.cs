using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests.Hooks
{
    public class HooksClass
    {
        /// # -*- coding: utf-8 -*-
        /// 
        /// """
        /// requests.hooks
        /// ~~~~~~~~~~~~~~
        /// 
        /// This module provides the capabilities for the Requests hooks system.
        /// 
        /// Available hooks:
        /// 
        /// ``response``:
        ///     The response generated from a Request.
        /// 
        /// """
        /// HOOKS = ['response']
        private static readonly string[] HOOKS = { "response" };
        /// 
        /// def default_hooks():
        ///     return dict((event, []) for event in HOOKS)
        public static Dictionary<string, List<T>> DefaultHooks<T>()
        {
            return new Dictionary<string, List<T>>(HOOKS.ToDictionary(x => x, x => new List<T>()));
        }
        /// 
        /// # TODO: response is the only one
        /// 
        /// 
        /// def dispatch_hook(key, hooks, hook_data, **kwargs):
        ///     """Dispatches a hook dictionary on a given piece of data."""
        ///     hooks = hooks or dict()
        ///     hooks = hooks.get(key)
        ///     if hooks:
        ///         if hasattr(hooks, '__call__'):
        ///             hooks = [hooks]
        ///         for hook in hooks:
        ///             _hook_data = hook(hook_data, **kwargs)
        ///             if _hook_data is not None:
        ///                 hook_data = _hook_data
        ///     return hook_data
    }
}
