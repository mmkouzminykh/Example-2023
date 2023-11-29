using Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpencesClient
{
    public interface IEditForm
    {
        public IEntity Element { get; }

        public bool Edit(IEntity element);
    }
}
