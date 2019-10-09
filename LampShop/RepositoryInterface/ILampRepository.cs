using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryInterface.Models;

namespace RepositoryInterface
{
    public interface ILampRepository
    {
	    Lamp[] GetAll();
    }
}
