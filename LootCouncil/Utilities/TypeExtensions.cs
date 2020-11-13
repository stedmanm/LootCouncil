using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LootCouncil.Utilities
{
    public static class TypeExtensions
    {
        public static IEnumerable<Type> FindSubTypesOfGenericTypeDefinition(this Type type)
        {
            return from t in Assembly.GetExecutingAssembly().GetTypes()
            where t != type &&
                  !t.IsAbstract &&
                  t.InheritsFromGenericTypeDefinition(type)
            select t;
        }

        public static bool InheritsFromGenericTypeDefinition(this Type type, Type genericType)
        {
            if (!genericType.IsGenericTypeDefinition)
                throw new ArgumentException("Must be a generic type definition.");
            
            if (!type.IsClass)
                return false;

            if (type.BaseType == null)
                return false;

            if (!type.BaseType.IsGenericType)
                return type.BaseType.InheritsFromGenericTypeDefinition(genericType);
            if (type.BaseType.GetGenericTypeDefinition() == genericType)
                return true;
            else
                return type.BaseType.InheritsFromGenericTypeDefinition(genericType);
        }

        public static bool InheritsFromType(this Type type, Type parentType)
        {
            if (!type.IsClass)
                return false;

            if (type.BaseType == null)
                return false;

            if (type.BaseType == parentType)
                return true;

            return InheritsFromType(type.BaseType, parentType);
        }
    }
}
