using Application.Interfaces.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class FieldMapAttribute : Attribute, IFieldMapAttribute
    {
        public string Field { get; set; }
        public FieldMapAttribute(string field)
        {
            Field = field;
        }
    }
}
