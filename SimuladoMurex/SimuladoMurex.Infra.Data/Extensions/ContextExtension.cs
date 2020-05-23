
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SimuladoMurex.Infra.Data.Extensions
{
    public static class ContextExtension
    {
        public static void LoadMappings(this ModelBuilder m)
        {
            var typesToMap = Assembly.GetExecutingAssembly()
                                     .GetTypes()
                                     .Where(x => x.Namespace == "SimuladoMurex.Infra.Data.Mappings"
                                              && x.IsClass
                                              && x.IsSealed).ToArray();

            foreach (var t in typesToMap)
            {
                dynamic mappingClass = Activator.CreateInstance(t);
                m.ApplyConfiguration(mappingClass);
            }
        }
    }
}
