using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskViewerApis.Helpers;
using TaskViewerApis.Interfaces;
using TaskViewerApis.Models;
using System.Collections.Generic;

namespace TaskViewerApis.Services
{
    public class LaService : ILaService
    {
        private readonly TaskViewerApis.Data.Context _context;

        public LaService(TaskViewerApis.Data.Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<La>> GetAllLas()
        {
            return await _context.Las.ToListAsync();
        }

        public async Task<La> GetLa(string plmId)
        {
            return await _context.Las.FirstOrDefaultAsync(l => l.PlmId == plmId);
        }

        public async Task<PaginatedResponse<La>> GetLaPage(
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
        )
        {
            var query = _context.Las.AsQueryable();

            if (!string.IsNullOrEmpty(projectSpace))
                query = query.Where(l => l.ProjectSpace == projectSpace);

            if (!string.IsNullOrEmpty(assignedPerson))
                query = query.Where(l => l.AssignedPerson == assignedPerson);

            if (!string.IsNullOrEmpty(decPsa))
                query = query.Where(l => l.DecPsa == decPsa);

            if (!string.IsNullOrEmpty(plmId))
                query = query.Where(l => l.PlmId == plmId);

            if (!string.IsNullOrEmpty(title))
                query = query.Where(l => l.Title == title);

            if (!string.IsNullOrEmpty(leader))
                query = query.Where(l => l.Leader == leader);

            if (!string.IsNullOrEmpty(managementState))
                query = query.Where(l => l.ManagementState == managementState);

            if (!string.IsNullOrEmpty(supervisor))
                query = query.Where(l => l.Supervisor == supervisor);

            if (!string.IsNullOrEmpty(service))
                query = query.Where(l => l.Service == service);

            if (!string.IsNullOrEmpty(toDoBy))
                query = query.Where(l => l.ToDoBy == toDoBy);

            if (!string.IsNullOrEmpty(satisfiedByEcoState))
                query = query.Where(l => l.SatisfiedByEcoState == satisfiedByEcoState);

            if (!string.IsNullOrEmpty(satisfiedByObjectId))
                query = query.Where(l => l.SatisfiedByObjectId == satisfiedByObjectId);

            if (!string.IsNullOrEmpty(satisfiedByRevision))
                query = query.Where(l => l.SatisfiedByRevision == satisfiedByRevision);

            if (!string.IsNullOrEmpty(satisfiedByEco))
                query = query.Where(l => l.SatisfiedByEco == satisfiedByEco);

            if (!string.IsNullOrEmpty(contextType))
                query = query.Where(l => l.ContextType == contextType);

            if (!string.IsNullOrEmpty(state))
                query = query.Where(l => l.State == state);

            if (!string.IsNullOrEmpty(coteRal))
                query = query.Where(l => l.CoterAl == coteRal);

            if (!string.IsNullOrEmpty(coteRt))
                query = query.Where(l => l.Cotert == coteRt);

            if (DateTime.TryParse(createdBetweenStart, out var createdStartDate))
                query = query.Where(l => l.CreatedAt >= createdStartDate);

            if (DateTime.TryParse(createdBetweenEnd, out var createdEndDate))
                query = query.Where(l => l.CreatedAt <= createdEndDate);

            if (DateTime.TryParse(releasedBetweenStart, out var releasedStartDate))
                query = query.Where(l => l.ReleasedDate >= releasedStartDate);

            if (DateTime.TryParse(releasedBetweenEnd, out var releasedEndDate))
                query = query.Where(l => l.ReleasedDate <= releasedEndDate);

            if (DateTime.TryParse(customerDateStart, out var customerStartDate))
                query = query.Where(l => l.CustomerDate >= customerStartDate);

            if (DateTime.TryParse(customerDateEnd, out var customerEndDate))
                query = query.Where(l => l.CustomerDate <= customerEndDate);

            if (DateTime.TryParse(canceledBetweenStart, out var canceledStartDate))
                query = query.Where(l => l.CancelledAt >= canceledStartDate);

            if (DateTime.TryParse(canceledBetweenEnd, out var canceledEndDate))
                query = query.Where(l => l.CancelledAt <= canceledEndDate);

            if (DateTime.TryParse(supplierDateStart, out var supplierStartDate))
                query = query.Where(l => l.SupplierDate >= supplierStartDate);

            if (DateTime.TryParse(supplierDateEnd, out var supplierEndDate))
                query = query.Where(l => l.SupplierDate <= supplierEndDate);

            if (DateTime.TryParse(agreedBetweenStart, out var agreedStartDate))
                query = query.Where(l => l.AgreedDate >= agreedStartDate);

            if (DateTime.TryParse(agreedBetweenEnd, out var agreedEndDate))
                query = query.Where(l => l.AgreedDate <= agreedEndDate);

            if (!string.IsNullOrEmpty(satisfiedByType))
                query = query.Where(l => l.SatisfiedByType == satisfiedByType);

            if (!string.IsNullOrEmpty(projectPackage))
                query = query.Where(l => l.ProjectPackage == projectPackage);

            if (!string.IsNullOrEmpty(expectedConf))
                query = query.Where(l => l.ExpectedConf == expectedConf);

            if (!string.IsNullOrEmpty(errors))
                query = query.Where(l => l.Errors == errors);

            if (!string.IsNullOrEmpty(linkedDocument))
                query = query.Where(l => l.LinkedDocument == linkedDocument);

            if (!string.IsNullOrEmpty(expectedConfTitle))
                query = query.Where(l => l.ExpectedConfTitle == expectedConfTitle);

            if (!string.IsNullOrEmpty(context))
                query = query.Where(l => l.Context == context);

            int totalCount = await query.CountAsync();

            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PaginatedResponse<La>
            {
                Items = items,
                TotalCount = totalCount
            };
        }
    }
}
