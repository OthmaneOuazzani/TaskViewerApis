using System.Threading.Tasks;
using TaskViewerApis.Helpers;
using TaskViewerApis.Models;
using System.Collections.Generic;

namespace TaskViewerApis.Interfaces
{
    public interface ILaService
    {
        Task<IEnumerable<La>> GetAllLas();
        Task<La> GetLa(string plmId);
        Task<PaginatedResponse<La>> GetLaPage(
            int page,
            int pageSize,
            string? projectSpace,
            string? assignedPerson,
            string? decPsa,
            string? plmId,
            string? title,
            string? leader,
            string? managementState,
            string? supervisor,
            string? service,
            string? toDoBy,
            string? satisfiedByEcoState,
            string? satisfiedByObjectId,
            string? satisfiedByRevision,
            string? satisfiedByEco,
            string? contextType,
            string? state,
            string? coteRal,
            string? coteRt,
            string? createdBetweenStart,
            string? createdBetweenEnd,
            string? releasedBetweenStart,
            string? releasedBetweenEnd,
            string? customerDateStart,
            string? customerDateEnd,
            string? canceledBetweenStart,
            string? canceledBetweenEnd,
            string? supplierDateStart,
            string? supplierDateEnd,
            string? agreedBetweenStart,
            string? agreedBetweenEnd,
            string? satisfiedByType,
            string? projectPackage,
            string? expectedConf,
            string? errors,
            string? linkedDocument,
            string? expectedConfTitle,
            string? context
        );
    }
}
