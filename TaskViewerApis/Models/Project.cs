﻿using System.ComponentModel.DataAnnotations;

namespace TaskViewer.Models
{
    public class Project
    {
        [Key]
        public string PlmId { get; set; }
        public string? ProjectName { get; set; }
        public string? ProductLine { get; set; }
        public string? Brand { get; set; }
        public string? Brothers { get; set; }
        public string? TwinProject { get; set; }
        public string? GasolinePwtCompatibility { get; set; }
        public string? DieselPwtCompatibility { get; set; }
        public string? ElectricPwtCompatibility { get; set; }
        public string? HybridPwtCompatibility { get; set; }
        public string? SilType { get; set; }
        public string? SilSize { get; set; }
        public string? AssociatedBoms { get; set; }
        public int? DbVersion { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ProjectType { get; set; }
        public string? Platform { get; set; }
        public string? Continent { get; set; }
        public int? NpCount { get; set; }
        public int? PaCount { get; set; }
        public int? PDefCount { get; set; }
        public int? PreaCount { get; set; }
        public int? CnxCount { get; set; }
        public int? PrfCount { get; set; }
        public int? PConfCount { get; set; }
        public string? PowerBom { get; set; }
        public DateTime? Sop { get; set; }
        public DateTime? ProjCreationDate { get; set; }
        public DateTime? PowerBomAssDate { get; set; }
        public DateTime? PowerBomProdDate { get; set; }
        public DateTime? LaDate { get; set; }
        public DateTime? EcoDate { get; set; }
        public DateTime? NpgDate { get; set; }
        public DateTime? BrothersSyncDate { get; set; }
        public DateTime? PageGenericGDate { get; set; }
        public DateTime? PDefPreAgendaDate { get; set; }
        public DateTime? MilestonesFileDate { get; set; }
        public DateTime? ExcDate { get; set; }
        public DateTime? PDefListDate { get; set; }
        public string? DefaultApplicability1 { get; set; }
        public string? DefaultApplicability2 { get; set; }
        public string? DefaultExc { get; set; }
        public string? DefaultWpk { get; set; }
        public string? DefaultUser { get; set; }
        public string? RefExc { get; set; }
        public string? ExcKw { get; set; }
        public string? OtherExc { get; set; }
        public int? NominalCnxNumber { get; set; }
        public string? PrfProgram { get; set; }
        public string? PrfProject { get; set; }
        public string? PortfolioPathDsee { get; set; }
        public string? PortfolioPathDchmInt { get; set; }
        public string? PortfolioPathDchmExt { get; set; }
        public string? PortfolioPathIcdv { get; set; }
        public string? PortfolioPathCmag { get; set; }
        public DateTime? PortfolioDateDsee { get; set; }
        public DateTime? PortfolioDateDchmInt { get; set; }
        public DateTime? PortfolioDateDchmExt { get; set; }
        public DateTime? PortfolioDateIcdv { get; set; }
        public DateTime? PortfolioDateCmag { get; set; }
        public string? ErrLogWrite { get; set; }
        public string? CnxBasedOnCnx { get; set; }
        public decimal? PrfEpsilon { get; set; }
        public string? PrfStdYear { get; set; }
        public string? CompodiagUpdated { get; set; }
        public string? Comments { get; set; }
        public string? Picture { get; set; }
        public string? CnxListBox { get; set; }
        public string? Projects { get; set; }
        public string? ExpectedConfs { get; set; }
        public string? PConfs { get; set; }
        public string? SmartMeasures { get; set; }
        public bool? ToKill { get; set; }
        public decimal? EcoCount { get; set; }
        public decimal? LACount { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string? LastUpdateBy { get; set; }
        public DateTime? PowerBomModDate { get; set; }
        public string? ConfigurationContext { get; set; }
        public string? BomOperators { get; set; }
        public string? EngOperators { get; set; }
        public string? ConfigurationContext1 { get; set; }
        public string? ConfigurationContext2 { get; set; }
        public string? ConfigurationContext3 { get; set; }
        public string? ConfigurationContext4 { get; set; }
        public string? ConfigurationContext5 { get; set; }
        public string? ConfigurationContexts { get; set; }
        public string? Vrf1 { get; set; }
        public bool? IsEcrDrivenBom { get; set; }
        public string? Vrf1Is100Pc { get; set; }
        public string? Vrf2 { get; set; }
        public string? Vrf2Is100Pc { get; set; }
        public string? Vrf3 { get; set; }
        public string? Vrf3Is100Pc { get; set; }
        public string? Vrf4 { get; set; }
        public string? Vrf4Is100Pc { get; set; }
        public string? Vrf5 { get; set; }
        public string? Vrf5Is100Pc { get; set; }
        public string? BomCommissionInCharge { get; set; }
        public string? LastTouch { get; set; }
        public string? ConfigurationContext6 { get; set; }
        public string? ConfigurationContext7 { get; set; }
        public string? ConfigurationContext8 { get; set; }
        public bool? OfflineAvailable { get; set; }
        public DateTime? OfflineDate { get; set; }
        public bool? IsOrphan { get; set; }
        public DateTime? LastValidBomDate { get; set; }
        public string? SecondaryOwnership { get; set; }
        public bool? DisablePopupMess { get; set; }
        public DateTime? PaOfficializeDate { get; set; }
        public string? LoadedBomDataCurrValue { get; set; }
        public string? LoadedBomDataIntmValue { get; set; }
        public string? LoadedBomDataRefValue { get; set; }
        public DateTime? LastLoadedBomDate { get; set; }
        public string? EcrDrivenCommissions { get; set; }
        public bool? IsFullyEcrDriven { get; set; }
        public string? TradeName { get; set; }
        public string? CnxRobotDirectory { get; set; }
        public string? CnxRobotEnabled { get; set; }
        public string? CnxRobotFileName { get; set; }
        public string? EcoProjectPattern1 { get; set; }
        public string? EcoProjectPattern2 { get; set; }
        public string? EcoProjectPattern3 { get; set; }
        public string? RobotComment { get; set; }
        public DateTime? LockDate { get; set; }
        public string? LockFlag { get; set; }
        public string? LockUser { get; set; }
        public string? Description { get; set; }
        public string? MarketingName { get; set; }
        public string? Partnership { get; set; }
        public string? ProjectTypePLM { get; set; }
        public string? FastenersManager { get; set; }
        public decimal? CountOfUndefinedGenomes { get; set; }
        public bool? IsUsingBomWorkshop { get; set; }
        public bool? IsUsingCnxWorkshop { get; set; }
        public bool? IsUsingTpcWorkshop { get; set; }
        public bool? IsUsingDnaWorkshop { get; set; }
        public decimal? NpCountPrev { get; set; }
        public decimal? PaCountPrev { get; set; }
        public decimal? PDefCountPrev { get; set; }
        public decimal? PreaCountPrev { get; set; }
        public decimal? CnxCountPrev { get; set; }
        public decimal? PrfCountPrev { get; set; }
        public decimal? PConfCountPrev { get; set; }
        public decimal? LaCountPrev { get; set; }
        public decimal? DnaCombineMax { get; set; }
        public decimal? DnaErrorsReportMax { get; set; }
        public decimal? DnaBumpCount { get; set; }
        public decimal? DnaHoleCount { get; set; }
        public decimal? DnaBumpHoleCount { get; set; }
        public decimal? DnaOtherCount { get; set; }
        public decimal? DnaHealthyCount { get; set; }
        public decimal? DnaBumpCountPrev { get; set; }
        public decimal? DnaHoleCountPrev { get; set; }
        public decimal? DnaBumpHoleCountPrev { get; set; }
        public decimal? DnaOtherCountPrev { get; set; }
        public decimal? DnaHealthyCountPrev { get; set; }
        public DateTime? DnaLastUpdate { get; set; }
        public decimal? EcoCountPrev { get; set; }
        public string? CommonCode { get; set; }
        public string? LfFixMon { get; set; }
        public string? LfFixSd { get; set; }
        public string? HpContext { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CancelledAt { get; set; }
    }
}
