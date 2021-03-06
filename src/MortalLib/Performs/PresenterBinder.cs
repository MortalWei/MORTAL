﻿using System;

namespace Lenovo.XtraCommon
{
    /// <summary>
    /// MVP模式 Presenter、View映射处理类
    /// </summary>
    public class PresenterBinder
    {
        /// <summary>
        /// 映射
        /// </summary>
        /// <param name="viewInstance"></param>
        /// <returns></returns>
        public IPresenter PerformBinding(IView viewInstance)
        {
            IPresenter presenter = null;
            Type t = viewInstance.GetType();//获取该视图的类类型
            object[] attrs = t.GetCustomAttributes(typeof(PresenterBindingAttribute), false);//获取该类上的附加特性集合

            //遍历特性集合，找到Presenter类型附加的特性，通过该特性建立实例
            foreach (PresenterBindingAttribute pba in attrs)
            {
                Type newt = pba.PresenterType;//获取Presenter类类型
                //建立Presenter实例，这里的构造参数是View的对象，这样就使两者建立了联系
                presenter = Activator.CreateInstance(pba.PresenterType, viewInstance) as IPresenter;
            }
            return presenter;
        }
    }
}
