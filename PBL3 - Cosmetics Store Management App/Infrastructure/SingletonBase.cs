using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.DTO
{
    public class SingletonBase<T> where T : class, new()
    {
        private static readonly Lazy<T> _Instance = new Lazy<T>( () => new T() );
        public static T Instance => _Instance.Value;
        protected SingletonBase() { }
    }
}
