using System;
using System.Collections.Generic;
using System.Text;
using Spring.Expressions;

namespace Org.Xwt.Nscl
{
    public class ELCache
    {

        private static ELCache instance = new ELCache();
        private IDictionary<string, IExpression> cache;

        private ELCache() 
        {
            cache = new Dictionary<string, IExpression>();
        }

        public static ELCache Instance
        {
            get { return instance; }
        }

        public IExpression GetExpression(string expression)
        {
            if(!cache.ContainsKey(expression))
            {
                cache.Add(expression, Expression.Parse(expression));
            }
            return cache[expression];
        }

        public bool GetBooleanValue(object root, string expression)
        {
            return Convert.ToBoolean(GetExpression(expression).GetValue(root));
        }

        public System.Collections.ICollection GetCollection(object root, string expression)
        {
            return (System.Collections.ICollection)GetExpression(expression).GetValue(root);
        }

        public object GetValue(object root, string expression)
        {
            return GetExpression(expression).GetValue(root);
        }

        public void SetValue(Object root, string varExpression, string valueExpression)
        {
            GetExpression(varExpression).SetValue(root, GetExpression(valueExpression).GetValue(root));
        }
        

    }
}
