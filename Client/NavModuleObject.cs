using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public class NavModuleObject
    {
        public NavModuleObject(string name, Type moduleType)
        {
            this.ModuleType = moduleType;
            this.Name = name;
        }
        public string Name { get; }
        public Type ModuleType { get; }

        public BaseModule Module { get; set; } = null;

    }
}
