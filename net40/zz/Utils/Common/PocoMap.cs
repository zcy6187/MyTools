using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class PocoMap
    {
        /// <summary>
        /// 将一个对象的同名属性映射另一个对象上
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="tIn"></param>
        /// <returns></returns>
        public static TOut MapSamePropertyToOther<TIn, TOut>(TIn tIn)
        {
            TOut tOut = Activator.CreateInstance<TOut>();
            var tInType = tIn.GetType();
            foreach (var itemOut in tOut.GetType().GetProperties())
            {
                var itemIn = tInType.GetProperty(itemOut.Name); ;
                if (itemIn != null)
                {
                    itemOut.SetValue(tOut, itemIn.GetValue(tIn,null),null);
                }
            }
            return tOut;
        }
    }
}
