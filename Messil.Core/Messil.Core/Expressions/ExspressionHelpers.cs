using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Messil.Core
{
    public static class ExspressionHelpers
    {
        public static T GetPropertyValue<T>(this Expression<Func<T>> lamba)
        {
            return lamba.Compile().Invoke();
        }

        public static void SetPropertyValue<T>(this Expression<Func<T>> lamba, T value)
        {
            var expression = (lamba as LambdaExpression).Body as MemberExpression;

            /// Gets property info
            var propertyInfo = (PropertyInfo)expression.Member;

            /// Gets ViewModel name
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            propertyInfo.SetValue(target, value);
        }
    }
}
