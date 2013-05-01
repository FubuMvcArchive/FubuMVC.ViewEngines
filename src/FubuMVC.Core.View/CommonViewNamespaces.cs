using System.Collections.Generic;

namespace FubuMVC.Core.View
{
    public class CommonViewNamespaces
    {
        private readonly IList<string> _namespaces = new List<string>();
        private bool _autoImportModelNamespaces = true;

        public void AddForType<T>()
        {
            _namespaces.Fill(typeof(T).Namespace);
        }

	public void DontAutoImportModelNamespaces()
	{
	    _autoImportModelNamespaces = false;
	}
        
        public void Add(string @namespace)
        {
            _namespaces.Fill(@namespace);
        }

        public IEnumerable<string> Namespaces
        {
            get { return _namespaces; }
        }

        public bool AutoImportModelNamespaces
        {
            get { return _autoImportModelNamespaces; }
        }
    }
}