using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WUI
{
    public interface IModel<TKey>
    {
        public TKey Id { get; }
    }
}
