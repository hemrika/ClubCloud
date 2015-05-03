using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
    /*
	[XmlInclude(typeof(TargetCreateAccount))]
	[XmlInclude(typeof(TargetCreateActivityMimeAttachment))]
	[XmlInclude(typeof(TargetCreateAnnotation))]
	[XmlInclude(typeof(TargetCreateAnnualFiscalCalendar))]
	[XmlInclude(typeof(TargetCreateAppointment))]
	[XmlInclude(typeof(TargetCreateAsyncOperation))]
	[XmlInclude(typeof(TargetCreateAttributeMap))]
	[XmlInclude(typeof(TargetCreateBusinessTask))]
	[XmlInclude(typeof(TargetCreateBusinessUnit))]
	[XmlInclude(typeof(TargetCreateBusinessUnitNewsArticle))]
	[XmlInclude(typeof(TargetCreateCalendar))]
	[XmlInclude(typeof(TargetCreateCampaign))]
	[XmlInclude(typeof(TargetCreateCampaignActivity))]
	[XmlInclude(typeof(TargetCreateCampaignResponse))]
	[XmlInclude(typeof(TargetCreateColumnMapping))]
	[XmlInclude(typeof(TargetCreateCompetitor))]
	[XmlInclude(typeof(TargetCreateConstraintBasedGroup))]
	[XmlInclude(typeof(TargetCreateContact))]
	[XmlInclude(typeof(TargetCreateContract))]
	[XmlInclude(typeof(TargetCreateContractDetail))]
	[XmlInclude(typeof(TargetCreateContractTemplate))]
	[XmlInclude(typeof(TargetCreateCustomerAddress))]
	[XmlInclude(typeof(TargetCreateCustomerOpportunityRole))]
	[XmlInclude(typeof(TargetCreateCustomerRelationship))]
	[XmlInclude(typeof(TargetCreateDiscount))]
	[XmlInclude(typeof(TargetCreateDiscountType))]
	[XmlInclude(typeof(TargetCreateDuplicateRule))]
	[XmlInclude(typeof(TargetCreateDuplicateRuleCondition))]
	[XmlInclude(typeof(TargetCreateDynamic))]
	[XmlInclude(typeof(TargetCreateEmail))]
	[XmlInclude(typeof(TargetCreateEquipment))]
	[XmlInclude(typeof(TargetCreateFax))]
	[XmlInclude(typeof(TargetCreateFixedMonthlyFiscalCalendar))]
	[XmlInclude(typeof(TargetCreateGi_FieldLevelSecurity))]
	[XmlInclude(typeof(TargetCreateImport))]
	[XmlInclude(typeof(TargetCreateImportData))]
	[XmlInclude(typeof(TargetCreateImportFile))]
	[XmlInclude(typeof(TargetCreateImportJob))]
	[XmlInclude(typeof(TargetCreateImportMap))]
	[XmlInclude(typeof(TargetCreateIncident))]
	[XmlInclude(typeof(TargetCreateIncidentResolution))]
	[XmlInclude(typeof(TargetCreateInvoice))]
	[XmlInclude(typeof(TargetCreateInvoiceDetail))]
	[XmlInclude(typeof(TargetCreateIsvConfig))]
	[XmlInclude(typeof(TargetCreateKbArticle))]
	[XmlInclude(typeof(TargetCreateKbArticleComment))]
	[XmlInclude(typeof(TargetCreateKbArticleTemplate))]
	[XmlInclude(typeof(TargetCreateLead))]
	[XmlInclude(typeof(TargetCreateLetter))]
	[XmlInclude(typeof(TargetCreateList))]
	[XmlInclude(typeof(TargetCreateLookUpMapping))]
	[XmlInclude(typeof(TargetCreateMailMergeTemplate))]
	[XmlInclude(typeof(TargetCreateMonthlyFiscalCalendar))]
	[XmlInclude(typeof(TargetCreateOpportunity))]
	[XmlInclude(typeof(TargetCreateOpportunityClose))]
	[XmlInclude(typeof(TargetCreateOpportunityProduct))]
	[XmlInclude(typeof(TargetCreateOrderClose))]
	[XmlInclude(typeof(TargetCreateOrganizationUI))]
	[XmlInclude(typeof(TargetCreateOwnerMapping))]
	[XmlInclude(typeof(TargetCreatePhoneCall))]
	[XmlInclude(typeof(TargetCreatePickListMapping))]
	[XmlInclude(typeof(TargetCreatePluginAssembly))]
	[XmlInclude(typeof(TargetCreatePluginType))]
	[XmlInclude(typeof(TargetCreatePriceLevel))]
	[XmlInclude(typeof(TargetCreateProduct))]
	[XmlInclude(typeof(TargetCreateProductPriceLevel))]
	[XmlInclude(typeof(TargetCreateQuarterlyFiscalCalendar))]
	[XmlInclude(typeof(TargetCreateQueue))]
	[XmlInclude(typeof(TargetCreateQuote))]
	[XmlInclude(typeof(TargetCreateQuoteClose))]
	[XmlInclude(typeof(TargetCreateQuoteDetail))]
	[XmlInclude(typeof(TargetCreateRelationshipRole))]
	[XmlInclude(typeof(TargetCreateRelationshipRoleMap))]
	[XmlInclude(typeof(TargetCreateReport))]
	[XmlInclude(typeof(TargetCreateReportCategory))]
	[XmlInclude(typeof(TargetCreateReportEntity))]
	[XmlInclude(typeof(TargetCreateReportVisibility))]
	[XmlInclude(typeof(TargetCreateResourceSpec))]
	[XmlInclude(typeof(TargetCreateRole))]
	[XmlInclude(typeof(TargetCreateSalesLiterature))]
	[XmlInclude(typeof(TargetCreateSalesLiteratureItem))]
	[XmlInclude(typeof(TargetCreateSalesOrder))]
	[XmlInclude(typeof(TargetCreateSalesOrderDetail))]
	[XmlInclude(typeof(TargetCreateSavedQuery))]
	[XmlInclude(typeof(TargetCreateSdkMessageProcessingStep))]
	[XmlInclude(typeof(TargetCreateSdkMessageProcessingStepImage))]
	[XmlInclude(typeof(TargetCreateSdkMessageProcessingStepSecureConfig))]
	[XmlInclude(typeof(TargetCreateSemiAnnualFiscalCalendar))]
	[XmlInclude(typeof(TargetCreateService))]
	[XmlInclude(typeof(TargetCreateServiceAppointment))]
	[XmlInclude(typeof(TargetCreateSgt_alg_abonnee))]
	[XmlInclude(typeof(TargetCreateSgt_alg_accommodatie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_activiteitenplan))]
	[XmlInclude(typeof(TargetCreateSgt_alg_ad_groep))]
	[XmlInclude(typeof(TargetCreateSgt_alg_ad_groep_bij_functie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_administratie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baan))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baan_gereserveerd))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baan_gereserveerd_vereniging))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baan_keuring))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baanblok))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baanblok_werkzaamheid))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baansoort))]
	[XmlInclude(typeof(TargetCreateSgt_alg_baantype))]
	[XmlInclude(typeof(TargetCreateSgt_alg_bestuursorgaan))]
	[XmlInclude(typeof(TargetCreateSgt_alg_betalingsvoorwaarde))]
	[XmlInclude(typeof(TargetCreateSgt_alg_boetes))]
	[XmlInclude(typeof(TargetCreateSgt_alg_bouwaard))]
	[XmlInclude(typeof(TargetCreateSgt_alg_btw_code))]
	[XmlInclude(typeof(TargetCreateSgt_alg_certificaat))]
	[XmlInclude(typeof(TargetCreateSgt_alg_certificaat_type))]
	[XmlInclude(typeof(TargetCreateSgt_alg_competentie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_custom_config))]
	[XmlInclude(typeof(TargetCreateSgt_alg_district))]
	[XmlInclude(typeof(TargetCreateSgt_alg_email_samenvoegveld))]
	[XmlInclude(typeof(TargetCreateSgt_alg_factuur_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_alg_flexibel_kenmerk))]
	[XmlInclude(typeof(TargetCreateSgt_alg_flexibel_kenmerk_type))]
	[XmlInclude(typeof(TargetCreateSgt_alg_formulier_antwoord))]
	[XmlInclude(typeof(TargetCreateSgt_alg_formulier_antwoord_veld))]
	[XmlInclude(typeof(TargetCreateSgt_alg_formulier_met_ideal))]
	[XmlInclude(typeof(TargetCreateSgt_alg_functie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_functionaris))]
	[XmlInclude(typeof(TargetCreateSgt_alg_functionele_log))]
	[XmlInclude(typeof(TargetCreateSgt_alg_gebeurtenis))]
	[XmlInclude(typeof(TargetCreateSgt_alg_gebeurtenis_beinvloeder))]
	[XmlInclude(typeof(TargetCreateSgt_alg_gebeurtenis_beinvloederrol))]
	[XmlInclude(typeof(TargetCreateSgt_alg_gebeurtenisgespreksonderwerp))]
	[XmlInclude(typeof(TargetCreateSgt_alg_gebeurtenistype))]
	[XmlInclude(typeof(TargetCreateSgt_alg_grootboekcode))]
	[XmlInclude(typeof(TargetCreateSgt_alg_IDEAL_betaling))]
	[XmlInclude(typeof(TargetCreateSgt_alg_ideal_betaling_gebeurtenis))]
	[XmlInclude(typeof(TargetCreateSgt_alg_inschrijf_functie_gebeurtenistype))]
	[XmlInclude(typeof(TargetCreateSgt_alg_kenmerk))]
	[XmlInclude(typeof(TargetCreateSgt_alg_kvk_branche))]
	[XmlInclude(typeof(TargetCreateSgt_alg_kvk_plaats))]
	[XmlInclude(typeof(TargetCreateSgt_alg_landcode))]
	[XmlInclude(typeof(TargetCreateSgt_alg_ledenpas_lid))]
	[XmlInclude(typeof(TargetCreateSgt_alg_ledenpas_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_alg_ledenpas_vereniging))]
	[XmlInclude(typeof(TargetCreateSgt_alg_leveringsconditie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_lidmaatschap))]
	[XmlInclude(typeof(TargetCreateSgt_alg_lidmaatschappen_omhangen))]
	[XmlInclude(typeof(TargetCreateSgt_alg_liggingkenmerk))]
	[XmlInclude(typeof(TargetCreateSgt_alg_logboek_dcp))]
	[XmlInclude(typeof(TargetCreateSgt_alg_logboek_fact_export_debiteuren))]
	[XmlInclude(typeof(TargetCreateSgt_alg_logboek_fact_export_facturen))]
	[XmlInclude(typeof(TargetCreateSgt_alg_logboek_fact_import_betalingen))]
	[XmlInclude(typeof(TargetCreateSgt_alg_logboek_ledenpas_bericht_per_ver))]
	[XmlInclude(typeof(TargetCreateSgt_alg_logboek_ledenpas_een_bericht))]
	[XmlInclude(typeof(TargetCreateSgt_alg_logboek_ledenpas_retour))]
	[XmlInclude(typeof(TargetCreateSgt_alg_lookupcontrol_filter))]
	[XmlInclude(typeof(TargetCreateSgt_alg_melding_maatwerk))]
	[XmlInclude(typeof(TargetCreateSgt_alg_nationaliteit))]
	[XmlInclude(typeof(TargetCreateSgt_alg_nummerreeks))]
	[XmlInclude(typeof(TargetCreateSgt_alg_nummerreeks_uitgave))]
	[XmlInclude(typeof(TargetCreateSgt_alg_occ_enabled_entity))]
	[XmlInclude(typeof(TargetCreateSgt_alg_onderwerp_activiteit))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pasfoto_bulkimport_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pastype))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_interface))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_interface_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_interface_logboek_export_xml))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_interface_logboek_import_xml))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_interface_logboek_leden_export))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_interface_logboek_leden_import))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_interface_logboek_logbestand))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_mutatie_accommodaties))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_mutatie_functionarissen))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_mutatie_leden))]
	[XmlInclude(typeof(TargetCreateSgt_alg_pb_mutatie_verenigingsinformatie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_periodiek_proces))]
	[XmlInclude(typeof(TargetCreateSgt_alg_persoonlijke_relatie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_postcode))]
	[XmlInclude(typeof(TargetCreateSgt_alg_postcode_import))]
	[XmlInclude(typeof(TargetCreateSgt_alg_rechtsvorm))]
	[XmlInclude(typeof(TargetCreateSgt_alg_record_lock))]
	[XmlInclude(typeof(TargetCreateSgt_alg_record_lock_maintenance))]
	[XmlInclude(typeof(TargetCreateSgt_alg_reden_afgekeurd))]
	[XmlInclude(typeof(TargetCreateSgt_alg_reisafstand))]
	[XmlInclude(typeof(TargetCreateSgt_alg_reset_password))]
	[XmlInclude(typeof(TargetCreateSgt_alg_rol_bij_functie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_rol_pers_relatie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_schorsing))]
	[XmlInclude(typeof(TargetCreateSgt_alg_servit1_contacthistorie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_soort_abonnement))]
	[XmlInclude(typeof(TargetCreateSgt_alg_soort_lidmaatschap))]
	[XmlInclude(typeof(TargetCreateSgt_alg_soort_verlichting))]
	[XmlInclude(typeof(TargetCreateSgt_alg_speciale_baan))]
	[XmlInclude(typeof(TargetCreateSgt_alg_team_bij_functie))]
	[XmlInclude(typeof(TargetCreateSgt_alg_telmethode))]
	[XmlInclude(typeof(TargetCreateSgt_alg_toplaag))]
	[XmlInclude(typeof(TargetCreateSgt_alg_type_bestuursorgaan))]
	[XmlInclude(typeof(TargetCreateSgt_alg_verzendwijze))]
	[XmlInclude(typeof(TargetCreateSgt_alg_virtueelteam))]
	[XmlInclude(typeof(TargetCreateSgt_alg_vrij_bondsnummer))]
	[XmlInclude(typeof(TargetCreateSgt_alg_workflow_timestamp))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitrage_functionaris))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitrage_indeling_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitrage_inzet_competitie))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitrage_inzet_toernooien))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitragebehoefte_competitie))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitragebehoefte_toernooi_per_dag))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitragebehoefte_toernooien))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitragebeschikbaarheid_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_arb_arbitragedag))]
	[XmlInclude(typeof(TargetCreateSgt_arb_behoefte_per_competitiewedstrijd))]
	[XmlInclude(typeof(TargetCreateSgt_arb_beoordeling_arbitragefunctionaris))]
	[XmlInclude(typeof(TargetCreateSgt_arb_beschikbaarheid_competitie))]
	[XmlInclude(typeof(TargetCreateSgt_arb_beschikbaarheid_toernooi_per_dag))]
	[XmlInclude(typeof(TargetCreateSgt_arb_rapport_hoofdscheidsrechter))]
	[XmlInclude(typeof(TargetCreateSgt_arb_sps_formulier))]
	[XmlInclude(typeof(TargetCreateSgt_arb_sps_straf))]
	[XmlInclude(typeof(TargetCreateSgt_arbitrage_inzet_per_dag))]
	[XmlInclude(typeof(TargetCreateSgt_autorisatie_entiteit_gekoppeld))]
	[XmlInclude(typeof(TargetCreateSgt_autorisatie_entity_per_team))]
	[XmlInclude(typeof(TargetCreateSgt_autorisatie_paden))]
	[XmlInclude(typeof(TargetCreateSgt_autorisatie_uitgifte))]
	[XmlInclude(typeof(TargetCreateSgt_bo_cursist))]
	[XmlInclude(typeof(TargetCreateSgt_bo_cursist_examen))]
	[XmlInclude(typeof(TargetCreateSgt_bo_examen))]
	[XmlInclude(typeof(TargetCreateSgt_bo_gewijzigde_persoonsgegevens))]
	[XmlInclude(typeof(TargetCreateSgt_bo_inschrijfformulier_testdag))]
	[XmlInclude(typeof(TargetCreateSgt_bo_licentie_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_bo_licentieaanvraag))]
	[XmlInclude(typeof(TargetCreateSgt_bo_licentiesoort))]
	[XmlInclude(typeof(TargetCreateSgt_bo_logboek_ecampus_resultaten))]
	[XmlInclude(typeof(TargetCreateSgt_bo_logboek_VNT))]
	[XmlInclude(typeof(TargetCreateSgt_bo_logboek_vnt_melding))]
	[XmlInclude(typeof(TargetCreateSgt_bo_opleiding))]
	[XmlInclude(typeof(TargetCreateSgt_bo_opleidingsgroep))]
	[XmlInclude(typeof(TargetCreateSgt_bo_soort_examen))]
	[XmlInclude(typeof(TargetCreateSgt_bo_tennisleraar))]
	[XmlInclude(typeof(TargetCreateSgt_bo_tennisleraar_geeft_les_bij))]
	[XmlInclude(typeof(TargetCreateSgt_bo_testdag))]
	[XmlInclude(typeof(TargetCreateSgt_bo_voorkeur_opleidingsgroep))]
	[XmlInclude(typeof(TargetCreateSgt_bo_voorkeur_testdag))]
	[XmlInclude(typeof(TargetCreateSgt_bo_vooropleiding))]
	[XmlInclude(typeof(TargetCreateSgt_com_aantal_afdelingen))]
	[XmlInclude(typeof(TargetCreateSgt_com_afdeling))]
	[XmlInclude(typeof(TargetCreateSgt_com_baan_gereserveerd_competitie))]
	[XmlInclude(typeof(TargetCreateSgt_com_beslissingswedstrijd))]
	[XmlInclude(typeof(TargetCreateSgt_com_bezoek_consul))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitie))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitie_afsluiting))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitie_districtsselectie))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitie_indeling))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitiegedelegeerde))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitieinschrijving))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitierecht))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitiesoort))]
	[XmlInclude(typeof(TargetCreateSgt_com_competitietype))]
	[XmlInclude(typeof(TargetCreateSgt_com_controle_dispensatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_controle_dispensatie_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_com_deelname_niet_knltb_lid))]
	[XmlInclude(typeof(TargetCreateSgt_com_ingedeelde_ploeg))]
	[XmlInclude(typeof(TargetCreateSgt_com_inschrijfbijdrage))]
	[XmlInclude(typeof(TargetCreateSgt_com_kalender))]
	[XmlInclude(typeof(TargetCreateSgt_com_klasse))]
	[XmlInclude(typeof(TargetCreateSgt_com_klassegroep))]
	[XmlInclude(typeof(TargetCreateSgt_com_klassevolgorde))]
	[XmlInclude(typeof(TargetCreateSgt_com_partij_uitslag))]
	[XmlInclude(typeof(TargetCreateSgt_com_partij_uitslag_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_piramide))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploeg))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploeginschrijving))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploeginschrijving_afhandeling))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploegmutatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploegnaam_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploegopgave))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploegsamenstelling))]
	[XmlInclude(typeof(TargetCreateSgt_com_ploegtoevoeging))]
	[XmlInclude(typeof(TargetCreateSgt_com_protest_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_reden_niet_gespeeld))]
	[XmlInclude(typeof(TargetCreateSgt_com_reeks_speeldatums))]
	[XmlInclude(typeof(TargetCreateSgt_com_speelschema_standaard))]
	[XmlInclude(typeof(TargetCreateSgt_com_speelschema_tegenovergesteld))]
	[XmlInclude(typeof(TargetCreateSgt_com_speelschema_wedstrijd))]
	[XmlInclude(typeof(TargetCreateSgt_com_spelersdispensatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_thuis_thuis_schema))]
	[XmlInclude(typeof(TargetCreateSgt_com_toegepast_speelschema))]
	[XmlInclude(typeof(TargetCreateSgt_com_toeslag_inschrijfbijdrage))]
	[XmlInclude(typeof(TargetCreateSgt_com_tussenstand_afdeling_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_com_uitnodiging_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_verenigingsdispensatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_verenigingsrecht))]
	[XmlInclude(typeof(TargetCreateSgt_com_wedstrijd_uitslag_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_com_wedstrijdgegevens))]
	[XmlInclude(typeof(TargetCreateSgt_dss_correctiewaarde_basisgetal))]
	[XmlInclude(typeof(TargetCreateSgt_dss_eindejaarsrating))]
	[XmlInclude(typeof(TargetCreateSgt_dss_grenswaarden_speelsterkte))]
	[XmlInclude(typeof(TargetCreateSgt_dss_Irreele_rs_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_dss_irreele_rs_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_dss_partijresultaat))]
	[XmlInclude(typeof(TargetCreateSgt_dss_ratinglogboek))]
	[XmlInclude(typeof(TargetCreateSgt_dss_ratingmutatie))]
	[XmlInclude(typeof(TargetCreateSgt_dss_reden_speelsterktemutatie))]
	[XmlInclude(typeof(TargetCreateSgt_dss_speelsterkte))]
	[XmlInclude(typeof(TargetCreateSgt_dss_speelsterktemut_reden_toe_afwijzing))]
	[XmlInclude(typeof(TargetCreateSgt_dss_speelsterktemutatie))]
	[XmlInclude(typeof(TargetCreateSgt_dss_speelsterktemutatie_aanvraag))]
	[XmlInclude(typeof(TargetCreateSgt_dss_speelsterktemutatie_afhandeling))]
	[XmlInclude(typeof(TargetCreateSgt_dss_spelersprofiel))]
	[XmlInclude(typeof(TargetCreateSgt_dss_tussentijdse_rating))]
	[XmlInclude(typeof(TargetCreateSgt_dss_tussentijdse_rating_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_dss_tussentijdse_rating_peildatum))]
	[XmlInclude(typeof(TargetCreateSgt_dss_variabelen_dss))]
	[XmlInclude(typeof(TargetCreateSgt_dynamicform))]
	[XmlInclude(typeof(TargetCreateSgt_dynamicformentity))]
	[XmlInclude(typeof(TargetCreateSgt_dynamicformfield))]
	[XmlInclude(typeof(TargetCreateSgt_dynamiclookup))]
	[XmlInclude(typeof(TargetCreateSgt_fac_buma_bijdrage_achtergrondmuziek))]
	[XmlInclude(typeof(TargetCreateSgt_fac_buma_bijdrage_amusementsmuziek))]
	[XmlInclude(typeof(TargetCreateSgt_fac_buma_soort_apparatuur))]
	[XmlInclude(typeof(TargetCreateSgt_fac_factuur_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_fac_factuur_type))]
	[XmlInclude(typeof(TargetCreateSgt_fac_factuur_type_factuurregel))]
	[XmlInclude(typeof(TargetCreateSgt_fac_factuurgroep))]
	[XmlInclude(typeof(TargetCreateSgt_fac_factuurgroep_toernooisoort))]
	[XmlInclude(typeof(TargetCreateSgt_fac_factuurverzameling))]
	[XmlInclude(typeof(TargetCreateSgt_functieperbestuursorgaan))]
	[XmlInclude(typeof(TargetCreateSgt_logboek_ecampus_resultaten_melding))]
	[XmlInclude(typeof(TargetCreateSgt_pbmutatietoernooidefinitieonderdeel))]
	[XmlInclude(typeof(TargetCreateSgt_rol_verbergen_entiteit))]
	[XmlInclude(typeof(TargetCreateSgt_rol_verbergen_tabbladen_secties))]
	[XmlInclude(typeof(TargetCreateSgt_smp_sitemap_toegang_af))]
	[XmlInclude(typeof(TargetCreateSgt_smp_sitemap_toegang_bgd))]
	[XmlInclude(typeof(TargetCreateSgt_smp_sitemap_toegang_cap))]
	[XmlInclude(typeof(TargetCreateSgt_smp_sitemap_toegang_knltb))]
	[XmlInclude(typeof(TargetCreateSgt_smp_sitemap_toegang_led))]
	[XmlInclude(typeof(TargetCreateSgt_smp_sitemap_toegang_vcl))]
	[XmlInclude(typeof(TargetCreateSgt_smp_sitemap_toegang_wl))]
	[XmlInclude(typeof(TargetCreateSgt_toe_aanvraagformulier))]
	[XmlInclude(typeof(TargetCreateSgt_toe_aanvraagformulier_dagtoernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_accepteren_speler_toernooisoort))]
	[XmlInclude(typeof(TargetCreateSgt_toe_administratieve_overtr_beroep))]
	[XmlInclude(typeof(TargetCreateSgt_toe_administratieve_overtr_beroep_mut))]
	[XmlInclude(typeof(TargetCreateSgt_toe_administratieve_overtr_strafbepalng))]
	[XmlInclude(typeof(TargetCreateSgt_toe_administratieve_overtr_strafmaat))]
	[XmlInclude(typeof(TargetCreateSgt_toe_administratieve_overtreding))]
	[XmlInclude(typeof(TargetCreateSgt_toe_administratieve_overtreding_mutatie))]
	[XmlInclude(typeof(TargetCreateSgt_toe_afwezigheid_bondsgedelegeerde))]
	[XmlInclude(typeof(TargetCreateSgt_toe_afwijkende_verdeling_geboortejaar))]
	[XmlInclude(typeof(TargetCreateSgt_toe_automatische_acceptatie_van_spelers))]
	[XmlInclude(typeof(TargetCreateSgt_toe_baansoort_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_basisschema))]
	[XmlInclude(typeof(TargetCreateSgt_toe_basisschema_partij))]
	[XmlInclude(typeof(TargetCreateSgt_toe_basisschema_ronde))]
	[XmlInclude(typeof(TargetCreateSgt_toe_bericht_inschrijving_vereniging))]
	[XmlInclude(typeof(TargetCreateSgt_toe_bondsgedelegeerde))]
	[XmlInclude(typeof(TargetCreateSgt_toe_circuit_bonuspunten))]
	[XmlInclude(typeof(TargetCreateSgt_toe_circuit_deelgetal))]
	[XmlInclude(typeof(TargetCreateSgt_toe_circuit_toernooionderdeel))]
	[XmlInclude(typeof(TargetCreateSgt_toe_circuitpunten))]
	[XmlInclude(typeof(TargetCreateSgt_toe_circuitpunten_toernooiresultaat))]
	[XmlInclude(typeof(TargetCreateSgt_toe_circuitranglijst_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_toe_constaterings_moment_AO))]
	[XmlInclude(typeof(TargetCreateSgt_toe_dagtoernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_dynamische_velden_per_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_inschrijf_functie_toernooisoort))]
	[XmlInclude(typeof(TargetCreateSgt_toe_inschrijfmethode_per_toernooisoort))]
	[XmlInclude(typeof(TargetCreateSgt_toe_inschrijfrecht_speler))]
	[XmlInclude(typeof(TargetCreateSgt_toe_koppeltabel_post_naar))]
	[XmlInclude(typeof(TargetCreateSgt_toe_kwalificatiecode))]
	[XmlInclude(typeof(TargetCreateSgt_toe_leeftijdscat_aanvraagformulier))]
	[XmlInclude(typeof(TargetCreateSgt_toe_leeftijdscategorie))]
	[XmlInclude(typeof(TargetCreateSgt_toe_niet_knltb_leden))]
	[XmlInclude(typeof(TargetCreateSgt_toe_partij_uitslag_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_interface_logboek_toernooi_fout))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_interface_logboek_toernooien))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooidefinitie))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_partij))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_poule))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_ps))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_ronde))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_set))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_team))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutatie_toernooiuitslag_to))]
	[XmlInclude(typeof(TargetCreateSgt_toe_pb_mutaute_inschrijfcontrole_ver))]
	[XmlInclude(typeof(TargetCreateSgt_toe_post_in))]
	[XmlInclude(typeof(TargetCreateSgt_toe_prijzengeld))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijst))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijst_bonuspunten))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijst_deelgetal))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijst_deelgetal_dubbelspel))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijst_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijstgroep))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijstpositie))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijstpunten))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ranglijstpunten_toernooiresultaat))]
	[XmlInclude(typeof(TargetCreateSgt_toe_reden_afwijzing_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_reden_annuleren_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_reden_dispensatie_toernooibijdrage))]
	[XmlInclude(typeof(TargetCreateSgt_toe_ronde_poule))]
	[XmlInclude(typeof(TargetCreateSgt_toe_schaduw_ranglijst_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_toe_schemagrootte))]
	[XmlInclude(typeof(TargetCreateSgt_toe_schemagrootte_per_toernooisoort))]
	[XmlInclude(typeof(TargetCreateSgt_toe_schemasoort))]
	[XmlInclude(typeof(TargetCreateSgt_toe_soortbal))]
	[XmlInclude(typeof(TargetCreateSgt_toe_special_exempt))]
	[XmlInclude(typeof(TargetCreateSgt_toe_speelsterktecategorie))]
	[XmlInclude(typeof(TargetCreateSgt_toe_spelersmemo))]
	[XmlInclude(typeof(TargetCreateSgt_toe_straf))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooi))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooi_aanvraagrecht))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooi_in_interface_logboek))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooi_op_toernooikalender))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooi_resultaten))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooiafhandeling))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooicircuit))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooien_reglementaire_arbitrage))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooigroep))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooikalender))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooionderdeel))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooionderdeel_ranglijst))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooionderdeelgenerator))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooischema))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooischema_per_schemagrootte))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooischema_speler))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooisoort))]
	[XmlInclude(typeof(TargetCreateSgt_toe_toernooispeler))]
	[XmlInclude(typeof(TargetCreateSgt_toe_type_ranglijst))]
	[XmlInclude(typeof(TargetCreateSgt_toe_uitzonderingsdag))]
	[XmlInclude(typeof(TargetCreateSgt_toe_wedstrijdschema))]
	[XmlInclude(typeof(TargetCreateSgt_toe_wildcard))]
	[XmlInclude(typeof(TargetCreateSgt_toe_zwaarte))]
	[XmlInclude(typeof(TargetCreateSgt_toe_zwaarte_op_toernooiniveau))]
	[XmlInclude(typeof(TargetCreateSgt_top_begeleiding))]
	[XmlInclude(typeof(TargetCreateSgt_top_geselecteerd_tennisser))]
	[XmlInclude(typeof(TargetCreateSgt_top_groep))]
	[XmlInclude(typeof(TargetCreateSgt_top_groep_deelnemers))]
	[XmlInclude(typeof(TargetCreateSgt_top_groepsbegeleiding))]
	[XmlInclude(typeof(TargetCreateSgt_top_groepsevenement))]
	[XmlInclude(typeof(TargetCreateSgt_top_groepsevenement_begeleiding))]
	[XmlInclude(typeof(TargetCreateSgt_top_soort_groep))]
	[XmlInclude(typeof(TargetCreateSgt_top_soort_groepsevenement))]
	[XmlInclude(typeof(TargetCreateSgt_top_tennissertype))]
	[XmlInclude(typeof(TargetCreateSgt_wt_inschrijfformulier_vcl_vtl))]
	[XmlInclude(typeof(TargetCreateSgt_wt_opleidingsfase))]
	[XmlInclude(typeof(TargetCreateSgt_wt_opleidingsfase_resultaat))]
	[XmlInclude(typeof(TargetCreateSgt_wt_opleidingsgroep_docent))]
	[XmlInclude(typeof(TargetCreateSite))]
	[XmlInclude(typeof(TargetCreateSubject))]
	[XmlInclude(typeof(TargetCreateSw_license))]
	[XmlInclude(typeof(TargetCreateSw_licensemanager))]
	[XmlInclude(typeof(TargetCreateSw_lookupcolumn))]
	[XmlInclude(typeof(TargetCreateSw_lookupdefinition))]
	[XmlInclude(typeof(TargetCreateSw_lookuplabels))]
	[XmlInclude(typeof(TargetCreateSw_lookuptemplate))]
	[XmlInclude(typeof(TargetCreateSw_lookupviewtranslation))]
	[XmlInclude(typeof(TargetCreateSw_picklist))]
	[XmlInclude(typeof(TargetCreateSw_retrievemultiplequery))]
	[XmlInclude(typeof(TargetCreateSw_retrievequery))]
	[XmlInclude(typeof(TargetCreateSw_tracelog))]
	[XmlInclude(typeof(TargetCreateSystemUser))]
	[XmlInclude(typeof(TargetCreateTask))]
	[XmlInclude(typeof(TargetCreateTeam))]
	[XmlInclude(typeof(TargetCreateTemplate))]
	[XmlInclude(typeof(TargetCreateTerritory))]
	[XmlInclude(typeof(TargetCreateTransactionCurrency))]
	[XmlInclude(typeof(TargetCreateTransformationMapping))]
	[XmlInclude(typeof(TargetCreateTransformationParameterMapping))]
	[XmlInclude(typeof(TargetCreateUoM))]
	[XmlInclude(typeof(TargetCreateUoMSchedule))]
	[XmlInclude(typeof(TargetCreateUserQuery))]
	[XmlInclude(typeof(TargetCreateWebWizard))]
	[XmlInclude(typeof(TargetCreateWizardAccessPrivilege))]
	[XmlInclude(typeof(TargetCreateWizardPage))]
	[XmlInclude(typeof(TargetCreateWorkflow))]
	[XmlInclude(typeof(TargetCreateWorkflowDependency))]
	[XmlInclude(typeof(TargetCreateWorkflowLog))]
    */
    [XmlSerializerAssembly(AssemblyName = "ClubCloud.KNLTB.XmlSerializers")]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public abstract class TargetCreate : INotifyPropertyChanged
	{
		protected TargetCreate()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}