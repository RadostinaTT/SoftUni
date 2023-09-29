namespace ValidationAttributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] objectProperties = obj.GetType()
                .GetProperties();

            foreach (var propertyInfo in objectProperties)
            {
                IEnumerable<MyValidationAttribute> propertyAttributes = propertyInfo
                    .GetCustomAttributes()
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>();

                foreach (var attribute in propertyAttributes)
                {
                    bool result = attribute.IsValid(propertyInfo.GetValue(obj));

                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}