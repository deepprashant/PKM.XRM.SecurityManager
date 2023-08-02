using PKM.SecurityManager.DataModelLayer;
using System;
using System.Collections.Generic;

namespace PKM.SecurityManager.ServiceLayer
{
    public interface IAssociationService<T>
    {
        IEnumerable<T> InitialLoadAndCacheRelatedData(string fetchXML, string searchName);
        IEnumerable<T> FetchAllRecords(IEnumerable<Guid> selectedBUs);
        IEnumerable<BaseAssociationModel> FetchAssociationTableRecords(string entityLogicalName, List<Guid> entityIds);
        void UpdatedAssociationTableRecords(IEnumerable<BaseAssociationModel> associations, bool assign);
    }
}