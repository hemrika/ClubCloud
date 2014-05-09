using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public enum EntityName
	{
		none,
		account,
		activitymimeattachment,
		activityparty,
		activitypointer,
		annotation,
		annualfiscalcalendar,
		appointment,
		asyncoperation,
		attributemap,
		bulkdeletefailure,
		bulkdeleteoperation,
		bulkoperation,
		bulkoperationlog,
		businesstask,
		businessunit,
		businessunitnewsarticle,
		calendar,
		calendarrule,
		campaign,
		campaignactivity,
		campaignactivityitem,
		campaignitem,
		campaignresponse,
		columnmapping,
		competitor,
		constraintbasedgroup,
		contact,
		contract,
		contractdetail,
		contracttemplate,
		customeraddress,
		customeropportunityrole,
		customerrelationship,
		discount,
		discounttype,
		displaystring,
		duplicaterecord,
		duplicaterule,
		duplicaterulecondition,
		email,
		entitymap,
		equipment,
		fax,
		fixedmonthlyfiscalcalendar,
		gi_fieldlevelsecurity,
		import,
		importdata,
		importfile,
		importjob,
		importlog,
		importmap,
		incident,
		incidentresolution,
		invoice,
		invoicedetail,
		isvconfig,
		kbarticle,
		kbarticlecomment,
		kbarticletemplate,
		lead,
		letter,
		license,
		list,
		listmember,
		lookupmapping,
		mailmergetemplate,
		monthlyfiscalcalendar,
		notification,
		opportunity,
		opportunityclose,
		opportunityproduct,
		orderclose,
		organization,
		organizationui,
		ownermapping,
		phonecall,
		picklistmapping,
		pluginassembly,
		plugintype,
		pricelevel,
		privilege,
		product,
		productpricelevel,
		quarterlyfiscalcalendar,
		queue,
		queueitem,
		quote,
		quoteclose,
		quotedetail,
		relationshiprole,
		relationshiprolemap,
		report,
		reportcategory,
		reportentity,
		reportlink,
		reportvisibility,
		resource,
		resourcegroup,
		resourcespec,
		role,
		salesliterature,
		salesliteratureitem,
		salesorder,
		salesorderdetail,
		savedquery,
		sdkmessage,
		sdkmessagefilter,
		sdkmessageprocessingstep,
		sdkmessageprocessingstepimage,
		sdkmessageprocessingstepsecureconfig,
		semiannualfiscalcalendar,
		service,
		serviceappointment,
		sgt_alg_abonnee,
		sgt_alg_accommodatie,
		sgt_alg_activiteitenplan,
		sgt_alg_ad_groep,
		sgt_alg_ad_groep_bij_functie,
		sgt_alg_administratie,
		sgt_alg_baan,
		sgt_alg_baan_gereserveerd,
		sgt_alg_baan_gereserveerd_vereniging,
		sgt_alg_baan_keuring,
		sgt_alg_baanblok,
		sgt_alg_baanblok_werkzaamheid,
		sgt_alg_baansoort,
		sgt_alg_baantype,
		sgt_alg_bestuursorgaan,
		sgt_alg_betalingsvoorwaarde,
		sgt_alg_boetes,
		sgt_alg_bouwaard,
		sgt_alg_btw_code,
		sgt_alg_certificaat,
		sgt_alg_certificaat_type,
		sgt_alg_competentie,
		sgt_alg_custom_config,
		sgt_alg_district,
		sgt_alg_email_samenvoegveld,
		sgt_alg_factuur_logboek,
		sgt_alg_flexibel_kenmerk,
		sgt_alg_flexibel_kenmerk_type,
		sgt_alg_formulier_antwoord,
		sgt_alg_formulier_antwoord_veld,
		sgt_alg_formulier_met_ideal,
		sgt_alg_functie,
		sgt_alg_functionaris,
		sgt_alg_functionele_log,
		sgt_alg_gebeurtenis,
		sgt_alg_gebeurtenis_beinvloeder,
		sgt_alg_gebeurtenis_beinvloederrol,
		sgt_alg_gebeurtenisgespreksonderwerp,
		sgt_alg_gebeurtenistype,
		sgt_alg_grootboekcode,
		sgt_alg_ideal_betaling,
		sgt_alg_ideal_betaling_gebeurtenis,
		sgt_alg_inschrijf_functie_gebeurtenistype,
		sgt_alg_kenmerk,
		sgt_alg_kvk_branche,
		sgt_alg_kvk_plaats,
		sgt_alg_landcode,
		sgt_alg_ledenpas_lid,
		sgt_alg_ledenpas_logboek,
		sgt_alg_ledenpas_vereniging,
		sgt_alg_leveringsconditie,
		sgt_alg_lidmaatschap,
		sgt_alg_lidmaatschappen_omhangen,
		sgt_alg_liggingkenmerk,
		sgt_alg_logboek_dcp,
		sgt_alg_logboek_fact_export_debiteuren,
		sgt_alg_logboek_fact_export_facturen,
		sgt_alg_logboek_fact_import_betalingen,
		sgt_alg_logboek_ledenpas_bericht_per_ver,
		sgt_alg_logboek_ledenpas_een_bericht,
		sgt_alg_logboek_ledenpas_retour,
		sgt_alg_lookupcontrol_filter,
		sgt_alg_melding_maatwerk,
		sgt_alg_nationaliteit,
		sgt_alg_nummerreeks,
		sgt_alg_nummerreeks_uitgave,
		sgt_alg_occ_enabled_entity,
		sgt_alg_onderwerp_activiteit,
		sgt_alg_pasfoto_bulkimport_logboek,
		sgt_alg_pastype,
		sgt_alg_pb_interface,
		sgt_alg_pb_interface_logboek,
		sgt_alg_pb_interface_logboek_export_xml,
		sgt_alg_pb_interface_logboek_import_xml,
		sgt_alg_pb_interface_logboek_leden_export,
		sgt_alg_pb_interface_logboek_leden_import,
		sgt_alg_pb_interface_logboek_logbestand,
		sgt_alg_pb_mutatie_accommodaties,
		sgt_alg_pb_mutatie_functionarissen,
		sgt_alg_pb_mutatie_leden,
		sgt_alg_pb_mutatie_verenigingsinformatie,
		sgt_alg_periodiek_proces,
		sgt_alg_persoonlijke_relatie,
		sgt_alg_postcode,
		sgt_alg_postcode_import,
		sgt_alg_rechtsvorm,
		sgt_alg_record_lock,
		sgt_alg_record_lock_maintenance,
		sgt_alg_reden_afgekeurd,
		sgt_alg_reisafstand,
		sgt_alg_reset_password,
		sgt_alg_rol_bij_functie,
		sgt_alg_rol_pers_relatie,
		sgt_alg_schorsing,
		sgt_alg_servit1_contacthistorie,
		sgt_alg_soort_abonnement,
		sgt_alg_soort_lidmaatschap,
		sgt_alg_soort_verlichting,
		sgt_alg_speciale_baan,
		sgt_alg_team_bij_functie,
		sgt_alg_telmethode,
		sgt_alg_toplaag,
		sgt_alg_type_bestuursorgaan,
		sgt_alg_verzendwijze,
		sgt_alg_virtueelteam,
		sgt_alg_vrij_bondsnummer,
		sgt_alg_workflow_timestamp,
		sgt_arb_arbitrage_functionaris,
		sgt_arb_arbitrage_indeling_toernooi,
		sgt_arb_arbitrage_inzet_competitie,
		sgt_arb_arbitrage_inzet_toernooien,
		sgt_arb_arbitragebehoefte_competitie,
		sgt_arb_arbitragebehoefte_toernooi_per_dag,
		sgt_arb_arbitragebehoefte_toernooien,
		sgt_arb_arbitragebeschikbaarheid_toernooi,
		sgt_arb_arbitragedag,
		sgt_arb_behoefte_per_competitiewedstrijd,
		sgt_arb_beoordeling_arbitragefunctionaris,
		sgt_arb_beschikbaarheid_competitie,
		sgt_arb_beschikbaarheid_toernooi_per_dag,
		sgt_arb_rapport_hoofdscheidsrechter,
		sgt_arb_sps_formulier,
		sgt_arb_sps_straf,
		sgt_arbitrage_inzet_per_dag,
		sgt_autorisatie_entiteit_gekoppeld,
		sgt_autorisatie_entity_per_team,
		sgt_autorisatie_paden,
		sgt_autorisatie_uitgifte,
		sgt_bo_cursist,
		sgt_bo_cursist_examen,
		sgt_bo_examen,
		sgt_bo_gewijzigde_persoonsgegevens,
		sgt_bo_inschrijfformulier_testdag,
		sgt_bo_licentie_logboek,
		sgt_bo_licentieaanvraag,
		sgt_bo_licentiesoort,
		sgt_bo_logboek_ecampus_resultaten,
		sgt_bo_logboek_vnt,
		sgt_bo_logboek_vnt_melding,
		sgt_bo_opleiding,
		sgt_bo_opleidingsgroep,
		sgt_bo_soort_examen,
		sgt_bo_tennisleraar,
		sgt_bo_tennisleraar_geeft_les_bij,
		sgt_bo_testdag,
		sgt_bo_voorkeur_opleidingsgroep,
		sgt_bo_voorkeur_testdag,
		sgt_bo_vooropleiding,
		sgt_com_afdeling,
		sgt_com_baan_gereserveerd_competitie,
		sgt_com_beslissingswedstrijd,
		sgt_com_bezoek_consul,
		sgt_com_competitie,
		sgt_com_competitie_afsluiting,
		sgt_com_competitie_districtsselectie,
		sgt_com_competitie_indeling,
		sgt_com_competitiegedelegeerde,
		sgt_com_competitieinschrijving,
		sgt_com_competitierecht,
		sgt_com_competitiesoort,
		sgt_com_competitietype,
		sgt_com_controle_dispensatie,
		sgt_com_controle_dispensatie_logboek,
		sgt_com_deelname_niet_knltb_lid,
		sgt_com_ingedeelde_ploeg,
		sgt_com_inschrijfbijdrage,
		sgt_com_kalender,
		sgt_com_klasse,
		sgt_com_klassegroep,
		sgt_com_klassevolgorde,
		sgt_com_partij_uitslag,
		sgt_com_partij_uitslag_mutatie,
		sgt_com_piramide,
		sgt_com_ploeg,
		sgt_com_ploeginschrijving,
		sgt_com_ploeginschrijving_afhandeling,
		sgt_com_ploegmutatie,
		sgt_com_ploegnaam_mutatie,
		sgt_com_ploegopgave,
		sgt_com_ploegsamenstelling,
		sgt_com_ploegtoevoeging,
		sgt_com_protest_mutatie,
		sgt_com_reden_niet_gespeeld,
		sgt_com_reeks_speeldatums,
		sgt_com_speelschema_standaard,
		sgt_com_speelschema_tegenovergesteld,
		sgt_com_speelschema_wedstrijd,
		sgt_com_spelersdispensatie,
		sgt_com_thuis_thuis_schema,
		sgt_com_toegepast_speelschema,
		sgt_com_toeslag_inschrijfbijdrage,
		sgt_com_tussenstand_afdeling_logboek,
		sgt_com_uitnodiging_mutatie,
		sgt_com_verenigingsdispensatie,
		sgt_com_verenigingsrecht,
		sgt_com_wedstrijd_uitslag_mutatie,
		sgt_com_wedstrijdgegevens,
		sgt_dss_correctiewaarde_basisgetal,
		sgt_dss_eindejaarsrating,
		sgt_dss_grenswaarden_speelsterkte,
		sgt_dss_irreele_rs_logboek,
		sgt_dss_irreele_rs_mutatie,
		sgt_dss_partijresultaat,
		sgt_dss_ratinglogboek,
		sgt_dss_ratingmutatie,
		sgt_dss_reden_speelsterktemutatie,
		sgt_dss_speelsterkte,
		sgt_dss_speelsterktemut_reden_toe_afwijzing,
		sgt_dss_speelsterktemutatie,
		sgt_dss_speelsterktemutatie_aanvraag,
		sgt_dss_speelsterktemutatie_afhandeling,
		sgt_dss_spelersprofiel,
		sgt_dss_tussentijdse_rating,
		sgt_dss_tussentijdse_rating_logboek,
		sgt_dss_tussentijdse_rating_peildatum,
		sgt_dss_variabelen_dss,
		sgt_dynamicform,
		sgt_dynamicformentity,
		sgt_dynamicformfield,
		sgt_dynamiclookup,
		sgt_fac_buma_bijdrage_achtergrondmuziek,
		sgt_fac_buma_bijdrage_amusementsmuziek,
		sgt_fac_buma_soort_apparatuur,
		sgt_fac_factuur_mutatie,
		sgt_fac_factuur_type,
		sgt_fac_factuur_type_factuurregel,
		sgt_fac_factuurgroep,
		sgt_fac_factuurgroep_toernooisoort,
		sgt_fac_factuurverzameling,
		sgt_functieperbestuursorgaan,
		sgt_logboek_ecampus_resultaten_melding,
		sgt_pbmutatietoernooidefinitieonderdeel,
		sgt_rol_verbergen_entiteit,
		sgt_rol_verbergen_tabbladen_secties,
		sgt_smp_sitemap_toegang_af,
		sgt_smp_sitemap_toegang_bgd,
		sgt_smp_sitemap_toegang_cap,
		sgt_smp_sitemap_toegang_knltb,
		sgt_smp_sitemap_toegang_led,
		sgt_smp_sitemap_toegang_vcl,
		sgt_smp_sitemap_toegang_wl,
		sgt_toe_aanvraagformulier,
		sgt_toe_aanvraagformulier_dagtoernooi,
		sgt_toe_accepteren_speler_toernooisoort,
		sgt_toe_administratieve_overtr_beroep,
		sgt_toe_administratieve_overtr_beroep_mut,
		sgt_toe_administratieve_overtr_strafbepalng,
		sgt_toe_administratieve_overtr_strafmaat,
		sgt_toe_administratieve_overtreding,
		sgt_toe_administratieve_overtreding_mutatie,
		sgt_toe_afwezigheid_bondsgedelegeerde,
		sgt_toe_afwijkende_verdeling_geboortejaar,
		sgt_toe_automatische_acceptatie_van_spelers,
		sgt_toe_baansoort_toernooi,
		sgt_toe_basisschema,
		sgt_toe_basisschema_partij,
		sgt_toe_basisschema_ronde,
		sgt_toe_bericht_inschrijving_vereniging,
		sgt_toe_bondsgedelegeerde,
		sgt_toe_circuit_bonuspunten,
		sgt_toe_circuit_deelgetal,
		sgt_toe_circuit_toernooionderdeel,
		sgt_toe_circuitpunten,
		sgt_toe_circuitpunten_toernooiresultaat,
		sgt_toe_circuitranglijst_logboek,
		sgt_toe_constaterings_moment_ao,
		sgt_toe_dagtoernooi,
		sgt_toe_dynamische_velden_per_toernooi,
		sgt_toe_inschrijf_functie_toernooisoort,
		sgt_toe_inschrijfmethode_per_toernooisoort,
		sgt_toe_inschrijfrecht_speler,
		sgt_toe_koppeltabel_post_naar,
		sgt_toe_kwalificatiecode,
		sgt_toe_leeftijdscat_aanvraagformulier,
		sgt_toe_leeftijdscategorie,
		sgt_toe_niet_knltb_leden,
		sgt_toe_partij_uitslag_toernooi,
		sgt_toe_pb_interface_logboek_toernooi_fout,
		sgt_toe_pb_interface_logboek_toernooien,
		sgt_toe_pb_mutatie_toernooidefinitie,
		sgt_toe_pb_mutatie_toernooiuitslag,
		sgt_toe_pb_mutatie_toernooiuitslag_partij,
		sgt_toe_pb_mutatie_toernooiuitslag_poule,
		sgt_toe_pb_mutatie_toernooiuitslag_ps,
		sgt_toe_pb_mutatie_toernooiuitslag_ronde,
		sgt_toe_pb_mutatie_toernooiuitslag_set,
		sgt_toe_pb_mutatie_toernooiuitslag_team,
		sgt_toe_pb_mutatie_toernooiuitslag_to,
		sgt_toe_pb_mutaute_inschrijfcontrole_ver,
		sgt_toe_post_in,
		sgt_toe_prijzengeld,
		sgt_toe_ranglijst,
		sgt_toe_ranglijst_bonuspunten,
		sgt_toe_ranglijst_deelgetal,
		sgt_toe_ranglijst_deelgetal_dubbelspel,
		sgt_toe_ranglijst_logboek,
		sgt_toe_ranglijstgroep,
		sgt_toe_ranglijstpositie,
		sgt_toe_ranglijstpunten,
		sgt_toe_ranglijstpunten_toernooiresultaat,
		sgt_toe_reden_afwijzing_toernooi,
		sgt_toe_reden_annuleren_toernooi,
		sgt_toe_reden_dispensatie_toernooibijdrage,
		sgt_toe_ronde_poule,
		sgt_toe_schaduw_ranglijst_logboek,
		sgt_toe_schemagrootte,
		sgt_toe_schemagrootte_per_toernooisoort,
		sgt_toe_schemasoort,
		sgt_toe_soortbal,
		sgt_toe_special_exempt,
		sgt_toe_speelsterktecategorie,
		sgt_toe_spelersmemo,
		sgt_toe_straf,
		sgt_toe_toernooi,
		sgt_toe_toernooi_aanvraagrecht,
		sgt_toe_toernooi_in_interface_logboek,
		sgt_toe_toernooi_op_toernooikalender,
		sgt_toe_toernooi_resultaten,
		sgt_toe_toernooiafhandeling,
		sgt_toe_toernooicircuit,
		sgt_toe_toernooien_reglementaire_arbitrage,
		sgt_toe_toernooigroep,
		sgt_toe_toernooikalender,
		sgt_toe_toernooionderdeel,
		sgt_toe_toernooionderdeel_ranglijst,
		sgt_toe_toernooionderdeelgenerator,
		sgt_toe_toernooischema,
		sgt_toe_toernooischema_per_schemagrootte,
		sgt_toe_toernooischema_speler,
		sgt_toe_toernooisoort,
		sgt_toe_toernooispeler,
		sgt_toe_type_ranglijst,
		sgt_toe_uitzonderingsdag,
		sgt_toe_wedstrijdschema,
		sgt_toe_wildcard,
		sgt_toe_zwaarte,
		sgt_toe_zwaarte_op_toernooiniveau,
		sgt_top_begeleiding,
		sgt_top_geselecteerd_tennisser,
		sgt_top_groep,
		sgt_top_groep_deelnemers,
		sgt_top_groepsbegeleiding,
		sgt_top_groepsevenement,
		sgt_top_groepsevenement_begeleiding,
		sgt_top_soort_groep,
		sgt_top_soort_groepsevenement,
		sgt_top_tennissertype,
		sgt_wt_inschrijfformulier_vcl_vtl,
		sgt_wt_opleidingsfase,
		sgt_wt_opleidingsfase_resultaat,
		sgt_wt_opleidingsgroep_docent,
		site,
		subject,
		subscription,
		subscriptionclients,
		subscriptionsyncinfo,
		sw_license,
		sw_licensemanager,
		sw_lookupcolumn,
		sw_lookupdefinition,
		sw_lookuplabels,
		sw_lookuptemplate,
		sw_lookupviewtranslation,
		sw_picklist,
		sw_retrievemultiplequery,
		sw_retrievequery,
		sw_tracelog,
		systemuser,
		task,
		team,
		template,
		territory,
		timezonedefinition,
		timezonelocalizedname,
		timezonerule,
		transactioncurrency,
		transformationmapping,
		transformationparametermapping,
		uom,
		uomschedule,
		userquery,
		usersettings,
		webwizard,
		wfprocess,
		wfprocessinstance,
		wizardaccessprivilege,
		wizardpage,
		workflow,
		workflowdependency,
		workflowlog
	}
}
