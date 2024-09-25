using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection._04
{
    public class Resolver
    {

        private Dictionary<Type, Type> dependenyMap = new Dictionary<Type, Type>();


        public void Register<TFrom, TTo>()
        {
            dependenyMap.Add(typeof(TFrom), typeof(TTo));
        }


        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private object Resolve(Type interfaceType)
        {
            Type classType;

            if (!dependenyMap.TryGetValue(interfaceType, out classType))
            {
                throw new Exception($"Could not resolve type { interfaceType.FullName }");
            }


            var ctr = classType.GetConstructors().First();

            var ctrPatametr = ctr.GetParameters();

            if(!ctrPatametr.Any())
            {
                return Activator.CreateInstance(classType);
            }


            List<object> parametrs = new List<object>();

            foreach (var item in ctrPatametr)
            {
                parametrs.Add(Resolve(item.ParameterType));
            }

            return ctr.Invoke(parametrs.ToArray());

        }

    }
}
