using System;

using R5T.Ostrogothia;using R5T.T0064;


namespace R5T.Oxford
{[ServiceDefinitionMarker]
    public interface IOrganizationProvider:IServiceDefinition
    {
        IOrganization GetOrganization();
    }
}
