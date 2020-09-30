
using System;

namespace AutoFrameWork.Base
{
   public class Basics
    {
        public readonly ParallelConfig _parallelConfig;

        public Basics(ParallelConfig parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            return (TPage)Activator.CreateInstance(typeof(TPage));
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }




    }
}
