using PKM.XRM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;

namespace PKM.XRM.SecurityManager.ServiceLayer
{
    public interface IAssociationService<T>
    {
        IEnumerable<T> InitialLoadAndCacheRelatedData(string fetchXML, string searchName);
        IEnumerable<T> FetchAllRecords(Guid selectedBU = default(Guid));
        IEnumerable<BaseAssociationModel> FetchAssociationTableRecords(string entityLogicalName, List<Guid> entityIds);
        void UpdatedAssociationTableRecords(IEnumerable<BaseAssociationModel> associations, bool assign);
    }
}