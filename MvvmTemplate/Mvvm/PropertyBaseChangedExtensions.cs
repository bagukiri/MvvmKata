using System;
using System.Linq.Expressions;

namespace MvvmTemplate.Mvvm
{
    //Additional MVVM base class methods
    public static class PropertyChangedBaseExtensions
    {
        //Return a property as a string, to avoid using 'magic strings' in MVVM pattern.
        //Usage: someClass.GetPropertyString((i) => i.PropertyName)
        public static string GetPropertyString<TSource, TProperty>(this TSource obj, Expression<Func<TSource, TProperty>> property) where TSource : PropertyChangedBase
        {
            var lambda = (LambdaExpression)property;
            MemberExpression memberExpression;
            if (lambda.Body is UnaryExpression)
            {
                var unaryExpression = (UnaryExpression)lambda.Body;
                memberExpression = (MemberExpression)unaryExpression.Operand;
            }
            else memberExpression = (MemberExpression)lambda.Body;
            return memberExpression.Member.Name;
        }
    }
}
