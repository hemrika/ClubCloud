using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(TargetRetrieveSgt_alg_pb_interface_logboek_leden_import)), XmlInclude(typeof(TargetRetrieveSgt_alg_nummerreeks_uitgave)), XmlInclude(typeof(TargetRetrieveSgt_bo_licentiesoort)), XmlInclude(typeof(TargetRetrieveWorkflowLog)), XmlInclude(typeof(TargetRetrieveWorkflowDependency)), XmlInclude(typeof(TargetRetrieveWorkflow)), XmlInclude(typeof(TargetRetrieveWizardPage)), XmlInclude(typeof(TargetRetrieveWizardAccessPrivilege)), XmlInclude(typeof(TargetRetrieveWFProcessInstance)), XmlInclude(typeof(TargetRetrieveWFProcess)), XmlInclude(typeof(TargetRetrieveWebWizard)), XmlInclude(typeof(TargetRetrieveUserQuery)), XmlInclude(typeof(TargetRetrieveUoMSchedule)), XmlInclude(typeof(TargetRetrieveUoM)), XmlInclude(typeof(TargetRetrieveTransformationParameterMapping)), XmlInclude(typeof(TargetRetrieveTransformationMapping)), XmlInclude(typeof(TargetRetrieveTransactionCurrency)), XmlInclude(typeof(TargetRetrieveTimeZoneRule)), XmlInclude(typeof(TargetRetrieveTimeZoneLocalizedName)), XmlInclude(typeof(TargetRetrieveTimeZoneDefinition)), XmlInclude(typeof(TargetRetrieveTerritory)), XmlInclude(typeof(TargetRetrieveTemplate)), XmlInclude(typeof(TargetRetrieveTeam)), XmlInclude(typeof(TargetRetrieveTask)), XmlInclude(typeof(TargetRetrieveSystemUser)), XmlInclude(typeof(TargetRetrieveSw_tracelog)), XmlInclude(typeof(TargetRetrieveSw_retrievequery)), XmlInclude(typeof(TargetRetrieveSw_retrievemultiplequery)), XmlInclude(typeof(TargetRetrieveSw_picklist)), XmlInclude(typeof(TargetRetrieveSw_lookupviewtranslation)), XmlInclude(typeof(TargetRetrieveSw_lookuptemplate)), XmlInclude(typeof(TargetRetrieveSw_lookuplabels)), XmlInclude(typeof(TargetRetrieveSw_lookupdefinition)), XmlInclude(typeof(TargetRetrieveSw_lookupcolumn)), XmlInclude(typeof(TargetRetrieveSw_licensemanager)), XmlInclude(typeof(TargetRetrieveSw_license)), XmlInclude(typeof(TargetRetrieveSubject)), XmlInclude(typeof(TargetRetrieveSite)), XmlInclude(typeof(TargetRetrieveSgt_wt_opleidingsgroep_docent)), XmlInclude(typeof(TargetRetrieveSgt_wt_opleidingsfase_resultaat)), XmlInclude(typeof(TargetRetrieveSgt_wt_opleidingsfase)), XmlInclude(typeof(TargetRetrieveSgt_wt_inschrijfformulier_vcl_vtl)), XmlInclude(typeof(TargetRetrieveSgt_top_tennissertype)), XmlInclude(typeof(TargetRetrieveSgt_top_soort_groepsevenement)), XmlInclude(typeof(TargetRetrieveSgt_top_soort_groep)), XmlInclude(typeof(TargetRetrieveSgt_top_groepsevenement_begeleiding)), XmlInclude(typeof(TargetRetrieveSgt_top_groepsevenement)), XmlInclude(typeof(TargetRetrieveSgt_top_groepsbegeleiding)), XmlInclude(typeof(TargetRetrieveSgt_top_groep_deelnemers)), XmlInclude(typeof(TargetRetrieveSgt_top_groep)), XmlInclude(typeof(TargetRetrieveSgt_top_geselecteerd_tennisser)), XmlInclude(typeof(TargetRetrieveSgt_top_begeleiding)), XmlInclude(typeof(TargetRetrieveSgt_toe_zwaarte_op_toernooiniveau)), XmlInclude(typeof(TargetRetrieveSgt_toe_zwaarte)), XmlInclude(typeof(TargetRetrieveSgt_toe_wildcard)), XmlInclude(typeof(TargetRetrieveSgt_toe_wedstrijdschema)), XmlInclude(typeof(TargetRetrieveSgt_toe_uitzonderingsdag)), XmlInclude(typeof(TargetRetrieveSgt_toe_type_ranglijst)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooispeler)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooisoort)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooischema_speler)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooischema_per_schemagrootte)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooischema)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooionderdeelgenerator)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooionderdeel_ranglijst)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooionderdeel)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooikalender)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooigroep)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooien_reglementaire_arbitrage)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooicircuit)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooiafhandeling)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooi_resultaten)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooi_op_toernooikalender)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooi_in_interface_logboek)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooi_aanvraagrecht)), XmlInclude(typeof(TargetRetrieveSgt_toe_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_straf)), XmlInclude(typeof(TargetRetrieveSgt_toe_spelersmemo)), XmlInclude(typeof(TargetRetrieveSgt_toe_speelsterktecategorie)), XmlInclude(typeof(TargetRetrieveSgt_toe_special_exempt)), XmlInclude(typeof(TargetRetrieveSgt_toe_soortbal)), XmlInclude(typeof(TargetRetrieveSgt_toe_schemasoort)), XmlInclude(typeof(TargetRetrieveSgt_toe_schemagrootte_per_toernooisoort)), XmlInclude(typeof(TargetRetrieveSgt_toe_schemagrootte)), XmlInclude(typeof(TargetRetrieveSgt_toe_schaduw_ranglijst_logboek)), XmlInclude(typeof(TargetRetrieveSgt_toe_ronde_poule)), XmlInclude(typeof(TargetRetrieveSgt_toe_reden_dispensatie_toernooibijdrage)), XmlInclude(typeof(TargetRetrieveSgt_toe_reden_annuleren_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_reden_afwijzing_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijstpunten_toernooiresultaat)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijstpunten)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijstpositie)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijstgroep)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijst_logboek)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijst_deelgetal_dubbelspel)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijst_deelgetal)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijst_bonuspunten)), XmlInclude(typeof(TargetRetrieveSgt_toe_ranglijst)), XmlInclude(typeof(TargetRetrieveSgt_toe_prijzengeld)), XmlInclude(typeof(TargetRetrieveSgt_toe_post_in)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutaute_inschrijfcontrole_ver)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag_to)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag_team)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag_set)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag_ronde)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag_ps)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag_poule)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag_partij)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooiuitslag)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_mutatie_toernooidefinitie)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_interface_logboek_toernooien)), XmlInclude(typeof(TargetRetrieveSgt_toe_pb_interface_logboek_toernooi_fout)), XmlInclude(typeof(TargetRetrieveSgt_toe_partij_uitslag_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_niet_knltb_leden)), XmlInclude(typeof(TargetRetrieveSgt_toe_leeftijdscategorie)), XmlInclude(typeof(TargetRetrieveSgt_toe_leeftijdscat_aanvraagformulier)), XmlInclude(typeof(TargetRetrieveSgt_toe_kwalificatiecode)), XmlInclude(typeof(TargetRetrieveSgt_toe_koppeltabel_post_naar)), XmlInclude(typeof(TargetRetrieveSgt_toe_inschrijfrecht_speler)), XmlInclude(typeof(TargetRetrieveSgt_toe_inschrijfmethode_per_toernooisoort)), XmlInclude(typeof(TargetRetrieveSgt_toe_inschrijf_functie_toernooisoort)), XmlInclude(typeof(TargetRetrieveSgt_toe_dynamische_velden_per_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_dagtoernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_constaterings_moment_AO)), XmlInclude(typeof(TargetRetrieveSgt_toe_circuitranglijst_logboek)), XmlInclude(typeof(TargetRetrieveSgt_toe_circuitpunten_toernooiresultaat)), XmlInclude(typeof(TargetRetrieveSgt_toe_circuitpunten)), XmlInclude(typeof(TargetRetrieveSgt_toe_circuit_toernooionderdeel)), XmlInclude(typeof(TargetRetrieveSgt_toe_circuit_deelgetal)), XmlInclude(typeof(TargetRetrieveSgt_toe_circuit_bonuspunten)), XmlInclude(typeof(TargetRetrieveSgt_toe_bondsgedelegeerde)), XmlInclude(typeof(TargetRetrieveSgt_toe_bericht_inschrijving_vereniging)), XmlInclude(typeof(TargetRetrieveSgt_toe_basisschema_ronde)), XmlInclude(typeof(TargetRetrieveSgt_toe_basisschema_partij)), XmlInclude(typeof(TargetRetrieveSgt_toe_basisschema)), XmlInclude(typeof(TargetRetrieveSgt_toe_baansoort_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_automatische_acceptatie_van_spelers)), XmlInclude(typeof(TargetRetrieveSgt_toe_afwijkende_verdeling_geboortejaar)), XmlInclude(typeof(TargetRetrieveSgt_toe_afwezigheid_bondsgedelegeerde)), XmlInclude(typeof(TargetRetrieveSgt_alg_onderwerp_activiteit)), XmlInclude(typeof(TargetRetrieveSgt_toe_administratieve_overtreding)), XmlInclude(typeof(TargetRetrieveSgt_toe_administratieve_overtr_strafmaat)), XmlInclude(typeof(TargetRetrieveSgt_toe_administratieve_overtr_strafbepalng)), XmlInclude(typeof(TargetRetrieveSgt_toe_administratieve_overtr_beroep_mut)), XmlInclude(typeof(TargetRetrieveSgt_toe_administratieve_overtr_beroep)), XmlInclude(typeof(TargetRetrieveSgt_toe_accepteren_speler_toernooisoort)), XmlInclude(typeof(TargetRetrieveSgt_toe_aanvraagformulier_dagtoernooi)), XmlInclude(typeof(TargetRetrieveSgt_toe_aanvraagformulier)), XmlInclude(typeof(TargetRetrieveSgt_smp_sitemap_toegang_wl)), XmlInclude(typeof(TargetRetrieveSgt_smp_sitemap_toegang_vcl)), XmlInclude(typeof(TargetRetrieveSgt_smp_sitemap_toegang_led)), XmlInclude(typeof(TargetRetrieveSgt_smp_sitemap_toegang_knltb)), XmlInclude(typeof(TargetRetrieveSgt_smp_sitemap_toegang_cap)), XmlInclude(typeof(TargetRetrieveSgt_smp_sitemap_toegang_bgd)), XmlInclude(typeof(TargetRetrieveSgt_smp_sitemap_toegang_af)), XmlInclude(typeof(TargetRetrieveSgt_rol_verbergen_tabbladen_secties)), XmlInclude(typeof(TargetRetrieveSgt_rol_verbergen_entiteit)), XmlInclude(typeof(TargetRetrieveSgt_pbmutatietoernooidefinitieonderdeel)), XmlInclude(typeof(TargetRetrieveSgt_logboek_ecampus_resultaten_melding)), XmlInclude(typeof(TargetRetrieveSgt_functieperbestuursorgaan)), XmlInclude(typeof(TargetRetrieveSgt_fac_factuurverzameling)), XmlInclude(typeof(TargetRetrieveSgt_fac_factuurgroep_toernooisoort)), XmlInclude(typeof(TargetRetrieveSgt_fac_factuurgroep)), XmlInclude(typeof(TargetRetrieveSgt_fac_factuur_type_factuurregel)), XmlInclude(typeof(TargetRetrieveSgt_fac_factuur_type)), XmlInclude(typeof(TargetRetrieveSgt_fac_factuur_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_fac_buma_soort_apparatuur)), XmlInclude(typeof(TargetRetrieveSgt_fac_buma_bijdrage_amusementsmuziek)), XmlInclude(typeof(TargetRetrieveSgt_fac_buma_bijdrage_achtergrondmuziek)), XmlInclude(typeof(TargetRetrieveSgt_dynamiclookup)), XmlInclude(typeof(TargetRetrieveSgt_dynamicformfield)), XmlInclude(typeof(TargetRetrieveSgt_dynamicformentity)), XmlInclude(typeof(TargetRetrieveSgt_dynamicform)), XmlInclude(typeof(TargetRetrieveSgt_dss_variabelen_dss)), XmlInclude(typeof(TargetRetrieveSgt_dss_tussentijdse_rating_peildatum)), XmlInclude(typeof(TargetRetrieveSgt_dss_tussentijdse_rating_logboek)), XmlInclude(typeof(TargetRetrieveSgt_dss_tussentijdse_rating)), XmlInclude(typeof(TargetRetrieveSgt_dss_spelersprofiel)), XmlInclude(typeof(TargetRetrieveSgt_dss_speelsterktemutatie_afhandeling)), XmlInclude(typeof(TargetRetrieveSgt_dss_speelsterktemutatie_aanvraag)), XmlInclude(typeof(TargetRetrieveSgt_dss_speelsterktemutatie)), XmlInclude(typeof(TargetRetrieveSgt_dss_speelsterktemut_reden_toe_afwijzing)), XmlInclude(typeof(TargetRetrieveSgt_dss_speelsterkte)), XmlInclude(typeof(TargetRetrieveSgt_dss_reden_speelsterktemutatie)), XmlInclude(typeof(TargetRetrieveSgt_dss_ratingmutatie)), XmlInclude(typeof(TargetRetrieveSgt_dss_ratinglogboek)), XmlInclude(typeof(TargetRetrieveSgt_dss_partijresultaat)), XmlInclude(typeof(TargetRetrieveSgt_dss_irreele_rs_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_dss_Irreele_rs_logboek)), XmlInclude(typeof(TargetRetrieveSgt_dss_grenswaarden_speelsterkte)), XmlInclude(typeof(TargetRetrieveSgt_dss_eindejaarsrating)), XmlInclude(typeof(TargetRetrieveSgt_dss_correctiewaarde_basisgetal)), XmlInclude(typeof(TargetRetrieveSgt_com_wedstrijdgegevens)), XmlInclude(typeof(TargetRetrieveSgt_com_wedstrijd_uitslag_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_com_verenigingsrecht)), XmlInclude(typeof(TargetRetrieveSgt_com_verenigingsdispensatie)), XmlInclude(typeof(TargetRetrieveSgt_com_uitnodiging_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_com_tussenstand_afdeling_logboek)), XmlInclude(typeof(TargetRetrieveSgt_com_toeslag_inschrijfbijdrage)), XmlInclude(typeof(TargetRetrieveSgt_com_toegepast_speelschema)), XmlInclude(typeof(TargetRetrieveSgt_com_thuis_thuis_schema)), XmlInclude(typeof(TargetRetrieveSgt_com_spelersdispensatie)), XmlInclude(typeof(TargetRetrieveSgt_com_speelschema_wedstrijd)), XmlInclude(typeof(TargetRetrieveSgt_com_speelschema_tegenovergesteld)), XmlInclude(typeof(TargetRetrieveSgt_com_speelschema_standaard)), XmlInclude(typeof(TargetRetrieveSgt_com_reeks_speeldatums)), XmlInclude(typeof(TargetRetrieveSgt_com_reden_niet_gespeeld)), XmlInclude(typeof(TargetRetrieveSgt_com_protest_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_com_ploegtoevoeging)), XmlInclude(typeof(TargetRetrieveSgt_com_ploegsamenstelling)), XmlInclude(typeof(TargetRetrieveSgt_com_ploegopgave)), XmlInclude(typeof(TargetRetrieveSgt_com_ploegnaam_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_com_ploegmutatie)), XmlInclude(typeof(TargetRetrieveSgt_com_ploeginschrijving_afhandeling)), XmlInclude(typeof(TargetRetrieveSgt_com_ploeginschrijving)), XmlInclude(typeof(TargetRetrieveSgt_com_ploeg)), XmlInclude(typeof(TargetRetrieveSgt_com_piramide)), XmlInclude(typeof(TargetRetrieveSgt_com_partij_uitslag_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_com_partij_uitslag)), XmlInclude(typeof(TargetRetrieveSgt_com_klassevolgorde)), XmlInclude(typeof(TargetRetrieveSgt_com_klassegroep)), XmlInclude(typeof(TargetRetrieveSgt_com_klasse)), XmlInclude(typeof(TargetRetrieveSgt_com_kalender)), XmlInclude(typeof(TargetRetrieveSgt_com_inschrijfbijdrage)), XmlInclude(typeof(TargetRetrieveSgt_com_ingedeelde_ploeg)), XmlInclude(typeof(TargetRetrieveSgt_com_deelname_niet_knltb_lid)), XmlInclude(typeof(TargetRetrieveSgt_com_controle_dispensatie_logboek)), XmlInclude(typeof(TargetRetrieveSgt_com_controle_dispensatie)), XmlInclude(typeof(TargetRetrieveSgt_com_competitietype)), XmlInclude(typeof(TargetRetrieveSgt_com_competitiesoort)), XmlInclude(typeof(TargetRetrieveSgt_com_competitierecht)), XmlInclude(typeof(TargetRetrieveSgt_com_competitieinschrijving)), XmlInclude(typeof(TargetRetrieveSgt_com_competitiegedelegeerde)), XmlInclude(typeof(TargetRetrieveSgt_com_competitie_indeling)), XmlInclude(typeof(TargetRetrieveSgt_com_competitie_districtsselectie)), XmlInclude(typeof(TargetRetrieveSgt_com_competitie_afsluiting)), XmlInclude(typeof(TargetRetrieveSgt_com_competitie)), XmlInclude(typeof(TargetRetrieveSgt_com_bezoek_consul)), XmlInclude(typeof(TargetRetrieveSgt_com_beslissingswedstrijd)), XmlInclude(typeof(TargetRetrieveSgt_com_baan_gereserveerd_competitie)), XmlInclude(typeof(TargetRetrieveSgt_com_afdeling)), XmlInclude(typeof(TargetRetrieveSgt_bo_vooropleiding)), XmlInclude(typeof(TargetRetrieveSgt_bo_voorkeur_testdag)), XmlInclude(typeof(TargetRetrieveSgt_bo_voorkeur_opleidingsgroep)), XmlInclude(typeof(TargetRetrieveSgt_bo_testdag)), XmlInclude(typeof(TargetRetrieveSgt_bo_tennisleraar_geeft_les_bij)), XmlInclude(typeof(TargetRetrieveSgt_bo_tennisleraar)), XmlInclude(typeof(TargetRetrieveSgt_bo_soort_examen)), XmlInclude(typeof(TargetRetrieveSgt_bo_opleidingsgroep)), XmlInclude(typeof(TargetRetrieveSgt_bo_opleiding)), XmlInclude(typeof(TargetRetrieveSgt_bo_logboek_vnt_melding)), XmlInclude(typeof(TargetRetrieveSgt_bo_logboek_VNT)), XmlInclude(typeof(TargetRetrieveSgt_bo_logboek_ecampus_resultaten)), XmlInclude(typeof(TargetRetrieveSgt_bo_licentieaanvraag)), XmlInclude(typeof(TargetRetrieveSgt_bo_licentie_logboek)), XmlInclude(typeof(TargetRetrieveSgt_bo_inschrijfformulier_testdag)), XmlInclude(typeof(TargetRetrieveSgt_bo_gewijzigde_persoonsgegevens)), XmlInclude(typeof(TargetRetrieveSgt_bo_examen)), XmlInclude(typeof(TargetRetrieveSgt_bo_cursist_examen)), XmlInclude(typeof(TargetRetrieveSgt_bo_cursist)), XmlInclude(typeof(TargetRetrieveSgt_autorisatie_uitgifte)), XmlInclude(typeof(TargetRetrieveSgt_autorisatie_paden)), XmlInclude(typeof(TargetRetrieveSgt_autorisatie_entity_per_team)), XmlInclude(typeof(TargetRetrieveSgt_autorisatie_entiteit_gekoppeld)), XmlInclude(typeof(TargetRetrieveSgt_arbitrage_inzet_per_dag)), XmlInclude(typeof(TargetRetrieveSgt_arb_sps_straf)), XmlInclude(typeof(TargetRetrieveSgt_arb_sps_formulier)), XmlInclude(typeof(TargetRetrieveSgt_arb_rapport_hoofdscheidsrechter)), XmlInclude(typeof(TargetRetrieveSgt_arb_beschikbaarheid_toernooi_per_dag)), XmlInclude(typeof(TargetRetrieveSgt_arb_beschikbaarheid_competitie)), XmlInclude(typeof(TargetRetrieveSgt_arb_beoordeling_arbitragefunctionaris)), XmlInclude(typeof(TargetRetrieveSgt_arb_behoefte_per_competitiewedstrijd)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitragedag)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitragebeschikbaarheid_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitragebehoefte_toernooien)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitragebehoefte_toernooi_per_dag)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitragebehoefte_competitie)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitrage_inzet_toernooien)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitrage_inzet_competitie)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitrage_indeling_toernooi)), XmlInclude(typeof(TargetRetrieveSgt_arb_arbitrage_functionaris)), XmlInclude(typeof(TargetRetrieveSgt_alg_workflow_timestamp)), XmlInclude(typeof(TargetRetrieveSgt_alg_vrij_bondsnummer)), XmlInclude(typeof(TargetRetrieveSgt_alg_virtueelteam)), XmlInclude(typeof(TargetRetrieveSgt_alg_verzendwijze)), XmlInclude(typeof(TargetRetrieveSgt_alg_type_bestuursorgaan)), XmlInclude(typeof(TargetRetrieveSgt_alg_toplaag)), XmlInclude(typeof(TargetRetrieveSgt_alg_telmethode)), XmlInclude(typeof(TargetRetrieveSgt_alg_team_bij_functie)), XmlInclude(typeof(TargetRetrieveSgt_alg_speciale_baan)), XmlInclude(typeof(TargetRetrieveSgt_alg_soort_verlichting)), XmlInclude(typeof(TargetRetrieveSgt_alg_soort_lidmaatschap)), XmlInclude(typeof(TargetRetrieveSgt_alg_soort_abonnement)), XmlInclude(typeof(TargetRetrieveSgt_alg_servit1_contacthistorie)), XmlInclude(typeof(TargetRetrieveSgt_alg_schorsing)), XmlInclude(typeof(TargetRetrieveSgt_alg_rol_pers_relatie)), XmlInclude(typeof(TargetRetrieveSgt_alg_rol_bij_functie)), XmlInclude(typeof(TargetRetrieveSgt_alg_reset_password)), XmlInclude(typeof(TargetRetrieveSgt_alg_reisafstand)), XmlInclude(typeof(TargetRetrieveSgt_alg_reden_afgekeurd)), XmlInclude(typeof(TargetRetrieveSgt_alg_record_lock_maintenance)), XmlInclude(typeof(TargetRetrieveSgt_alg_record_lock)), XmlInclude(typeof(TargetRetrieveSgt_alg_rechtsvorm)), XmlInclude(typeof(TargetRetrieveSgt_alg_postcode_import)), XmlInclude(typeof(TargetRetrieveSgt_alg_postcode)), XmlInclude(typeof(TargetRetrieveSgt_alg_persoonlijke_relatie)), XmlInclude(typeof(TargetRetrieveSgt_alg_periodiek_proces)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_mutatie_verenigingsinformatie)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_mutatie_leden)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_mutatie_functionarissen)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_mutatie_accommodaties)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_interface_logboek_logbestand)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_interface_logboek_leden_export)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_interface_logboek_import_xml)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_interface_logboek_export_xml)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_interface_logboek)), XmlInclude(typeof(TargetRetrieveSgt_alg_pb_interface)), XmlInclude(typeof(TargetRetrieveSgt_alg_pastype)), XmlInclude(typeof(TargetRetrieveSgt_alg_pasfoto_bulkimport_logboek)), XmlInclude(typeof(TargetRetrieveRelationshipRoleMap)), XmlInclude(typeof(TargetRetrieveSgt_alg_occ_enabled_entity)), XmlInclude(typeof(TargetRetrieveSgt_toe_administratieve_overtreding_mutatie)), XmlInclude(typeof(TargetRetrieveSgt_alg_nummerreeks)), XmlInclude(typeof(TargetRetrieveSgt_alg_nationaliteit)), XmlInclude(typeof(TargetRetrieveSgt_alg_melding_maatwerk)), XmlInclude(typeof(TargetRetrieveSgt_alg_lookupcontrol_filter)), XmlInclude(typeof(TargetRetrieveSgt_alg_logboek_ledenpas_retour)), XmlInclude(typeof(TargetRetrieveSgt_alg_logboek_ledenpas_een_bericht)), XmlInclude(typeof(TargetRetrieveSgt_alg_logboek_ledenpas_bericht_per_ver)), XmlInclude(typeof(TargetRetrieveSgt_alg_logboek_fact_import_betalingen)), XmlInclude(typeof(TargetRetrieveSgt_alg_logboek_fact_export_facturen)), XmlInclude(typeof(TargetRetrieveSgt_alg_logboek_fact_export_debiteuren)), XmlInclude(typeof(TargetRetrieveSgt_alg_logboek_dcp)), XmlInclude(typeof(TargetRetrieveSgt_alg_liggingkenmerk)), XmlInclude(typeof(TargetRetrieveSgt_alg_lidmaatschappen_omhangen)), XmlInclude(typeof(TargetRetrieveSgt_alg_lidmaatschap)), XmlInclude(typeof(TargetRetrieveSgt_alg_leveringsconditie)), XmlInclude(typeof(TargetRetrieveSgt_alg_ledenpas_vereniging)), XmlInclude(typeof(TargetRetrieveSgt_alg_ledenpas_logboek)), XmlInclude(typeof(TargetRetrieveSgt_alg_ledenpas_lid)), XmlInclude(typeof(TargetRetrieveSgt_alg_landcode)), XmlInclude(typeof(TargetRetrieveSgt_alg_kvk_plaats)), XmlInclude(typeof(TargetRetrieveSgt_alg_kvk_branche)), XmlInclude(typeof(TargetRetrieveSgt_alg_kenmerk)), XmlInclude(typeof(TargetRetrieveSgt_alg_inschrijf_functie_gebeurtenistype)), XmlInclude(typeof(TargetRetrieveSgt_alg_ideal_betaling_gebeurtenis)), XmlInclude(typeof(TargetRetrieveSgt_alg_IDEAL_betaling)), XmlInclude(typeof(TargetRetrieveSgt_alg_grootboekcode)), XmlInclude(typeof(TargetRetrieveSgt_alg_gebeurtenistype)), XmlInclude(typeof(TargetRetrieveSgt_alg_gebeurtenisgespreksonderwerp)), XmlInclude(typeof(TargetRetrieveSgt_alg_gebeurtenis_beinvloederrol)), XmlInclude(typeof(TargetRetrieveSgt_alg_gebeurtenis_beinvloeder)), XmlInclude(typeof(TargetRetrieveSgt_alg_gebeurtenis)), XmlInclude(typeof(TargetRetrieveSgt_alg_functionele_log)), XmlInclude(typeof(TargetRetrieveSgt_alg_functionaris)), XmlInclude(typeof(TargetRetrieveSgt_alg_functie)), XmlInclude(typeof(TargetRetrieveSgt_alg_formulier_met_ideal)), XmlInclude(typeof(TargetRetrieveSgt_alg_formulier_antwoord_veld)), XmlInclude(typeof(TargetRetrieveSgt_alg_formulier_antwoord)), XmlInclude(typeof(TargetRetrieveSgt_alg_flexibel_kenmerk_type)), XmlInclude(typeof(TargetRetrieveSgt_alg_flexibel_kenmerk)), XmlInclude(typeof(TargetRetrieveSgt_alg_factuur_logboek)), XmlInclude(typeof(TargetRetrieveSgt_alg_email_samenvoegveld)), XmlInclude(typeof(TargetRetrieveSgt_alg_district)), XmlInclude(typeof(TargetRetrieveSgt_alg_custom_config)), XmlInclude(typeof(TargetRetrieveSgt_alg_competentie)), XmlInclude(typeof(TargetRetrieveSgt_alg_certificaat_type)), XmlInclude(typeof(TargetRetrieveSgt_alg_certificaat)), XmlInclude(typeof(TargetRetrieveSgt_alg_btw_code)), XmlInclude(typeof(TargetRetrieveSgt_alg_bouwaard)), XmlInclude(typeof(TargetRetrieveSgt_alg_boetes)), XmlInclude(typeof(TargetRetrieveSgt_alg_betalingsvoorwaarde)), XmlInclude(typeof(TargetRetrieveSgt_alg_bestuursorgaan)), XmlInclude(typeof(TargetRetrieveSgt_alg_baantype)), XmlInclude(typeof(TargetRetrieveSgt_alg_baansoort)), XmlInclude(typeof(TargetRetrieveSgt_alg_baanblok_werkzaamheid)), XmlInclude(typeof(TargetRetrieveSgt_alg_baanblok)), XmlInclude(typeof(TargetRetrieveSgt_alg_baan_keuring)), XmlInclude(typeof(TargetRetrieveSgt_alg_baan_gereserveerd_vereniging)), XmlInclude(typeof(TargetRetrieveSgt_alg_baan_gereserveerd)), XmlInclude(typeof(TargetRetrieveSgt_alg_baan)), XmlInclude(typeof(TargetRetrieveSgt_alg_administratie)), XmlInclude(typeof(TargetRetrieveSgt_alg_ad_groep_bij_functie)), XmlInclude(typeof(TargetRetrieveSgt_alg_ad_groep)), XmlInclude(typeof(TargetRetrieveSgt_alg_activiteitenplan)), XmlInclude(typeof(TargetRetrieveSgt_alg_accommodatie)), XmlInclude(typeof(TargetRetrieveSgt_alg_abonnee)), XmlInclude(typeof(TargetRetrieveServiceAppointment)), XmlInclude(typeof(TargetRetrieveService)), XmlInclude(typeof(TargetRetrieveSemiAnnualFiscalCalendar)), XmlInclude(typeof(TargetRetrieveSdkMessageProcessingStepSecureConfig)), XmlInclude(typeof(TargetRetrieveSdkMessageProcessingStepImage)), XmlInclude(typeof(TargetRetrieveSdkMessageProcessingStep)), XmlInclude(typeof(TargetRetrieveSdkMessageFilter)), XmlInclude(typeof(TargetRetrieveSdkMessage)), XmlInclude(typeof(TargetRetrieveSavedQuery)), XmlInclude(typeof(TargetRetrieveSalesOrderDetail)), XmlInclude(typeof(TargetRetrieveSalesOrder)), XmlInclude(typeof(TargetRetrieveSalesLiteratureItem)), XmlInclude(typeof(TargetRetrieveSalesLiterature)), XmlInclude(typeof(TargetRetrieveRole)), XmlInclude(typeof(TargetRetrieveResourceSpec)), XmlInclude(typeof(TargetRetrieveResourceGroup)), XmlInclude(typeof(TargetRetrieveResource)), XmlInclude(typeof(TargetRetrieveReportVisibility)), XmlInclude(typeof(TargetRetrieveReportLink)), XmlInclude(typeof(TargetRetrieveReportEntity)), XmlInclude(typeof(TargetRetrieveReportCategory)), XmlInclude(typeof(TargetRetrieveReport)), XmlInclude(typeof(TargetRetrieveFax)), XmlInclude(typeof(TargetRetrieveRelationshipRole)), XmlInclude(typeof(TargetRetrieveQuoteDetail)), XmlInclude(typeof(TargetRetrieveQuoteClose)), XmlInclude(typeof(TargetRetrieveQuote)), XmlInclude(typeof(TargetRetrieveQueueItem)), XmlInclude(typeof(TargetRetrieveQueue)), XmlInclude(typeof(TargetRetrieveQuarterlyFiscalCalendar)), XmlInclude(typeof(TargetRetrieveProductPriceLevel)), XmlInclude(typeof(TargetRetrieveProduct)), XmlInclude(typeof(TargetRetrievePrivilege)), XmlInclude(typeof(TargetRetrievePriceLevel)), XmlInclude(typeof(TargetRetrievePluginType)), XmlInclude(typeof(TargetRetrievePluginAssembly)), XmlInclude(typeof(TargetRetrievePickListMapping)), XmlInclude(typeof(TargetRetrievePhoneCall)), XmlInclude(typeof(TargetRetrieveOwnerMapping)), XmlInclude(typeof(TargetRetrieveOrganizationUI)), XmlInclude(typeof(TargetRetrieveOrganization)), XmlInclude(typeof(TargetRetrieveOrderClose)), XmlInclude(typeof(TargetRetrieveOpportunityProduct)), XmlInclude(typeof(TargetRetrieveOpportunityClose)), XmlInclude(typeof(TargetRetrieveOpportunity)), XmlInclude(typeof(TargetRetrieveMonthlyFiscalCalendar)), XmlInclude(typeof(TargetRetrieveMailMergeTemplate)), XmlInclude(typeof(TargetRetrieveLookUpMapping)), XmlInclude(typeof(TargetRetrieveList)), XmlInclude(typeof(TargetRetrieveLetter)), XmlInclude(typeof(TargetRetrieveLead)), XmlInclude(typeof(TargetRetrieveKbArticleTemplate)), XmlInclude(typeof(TargetRetrieveKbArticleComment)), XmlInclude(typeof(TargetRetrieveKbArticle)), XmlInclude(typeof(TargetRetrieveIsvConfig)), XmlInclude(typeof(TargetRetrieveInvoiceDetail)), XmlInclude(typeof(TargetRetrieveInvoice)), XmlInclude(typeof(TargetRetrieveIncidentResolution)), XmlInclude(typeof(TargetRetrieveIncident)), XmlInclude(typeof(TargetRetrieveImportMap)), XmlInclude(typeof(TargetRetrieveImportLog)), XmlInclude(typeof(TargetRetrieveImportJob)), XmlInclude(typeof(TargetRetrieveImportFile)), XmlInclude(typeof(TargetRetrieveImportData)), XmlInclude(typeof(TargetRetrieveImport)), XmlInclude(typeof(TargetRetrieveGi_FieldLevelSecurity)), XmlInclude(typeof(TargetRetrieveFixedMonthlyFiscalCalendar)), XmlInclude(typeof(TargetRetrieveCampaign)), XmlInclude(typeof(TargetRetrieveEntityMap)), XmlInclude(typeof(TargetRetrieveEmail)), XmlInclude(typeof(TargetRetrieveDynamic)), XmlInclude(typeof(TargetRetrieveDuplicateRuleCondition)), XmlInclude(typeof(TargetRetrieveDuplicateRule)), XmlInclude(typeof(TargetRetrieveDuplicateRecord)), XmlInclude(typeof(TargetRetrieveDisplayString)), XmlInclude(typeof(TargetRetrieveDiscountType)), XmlInclude(typeof(TargetRetrieveDiscount)), XmlInclude(typeof(TargetRetrieveCustomerRelationship)), XmlInclude(typeof(TargetRetrieveCustomerOpportunityRole)), XmlInclude(typeof(TargetRetrieveCustomerAddress)), XmlInclude(typeof(TargetRetrieveContractTemplate)), XmlInclude(typeof(TargetRetrieveContractDetail)), XmlInclude(typeof(TargetRetrieveContract)), XmlInclude(typeof(TargetRetrieveContact)), XmlInclude(typeof(TargetRetrieveConstraintBasedGroup)), XmlInclude(typeof(TargetRetrieveCompetitor)), XmlInclude(typeof(TargetRetrieveColumnMapping)), XmlInclude(typeof(TargetRetrieveCampaignResponse)), XmlInclude(typeof(TargetRetrieveCampaignActivity)), XmlInclude(typeof(TargetRetrieveEquipment)), XmlInclude(typeof(TargetRetrieveCalendar)), XmlInclude(typeof(TargetRetrieveBusinessUnitNewsArticle)), XmlInclude(typeof(TargetRetrieveBusinessUnit)), XmlInclude(typeof(TargetRetrieveBusinessTask)), XmlInclude(typeof(TargetRetrieveBulkOperationLog)), XmlInclude(typeof(TargetRetrieveBulkOperation)), XmlInclude(typeof(TargetRetrieveBulkDeleteOperation)), XmlInclude(typeof(TargetRetrieveBulkDeleteFailure)), XmlInclude(typeof(TargetRetrieveAttributeMap)), XmlInclude(typeof(TargetRetrieveAsyncOperation)), XmlInclude(typeof(TargetRetrieveAppointment)), XmlInclude(typeof(TargetRetrieveAnnualFiscalCalendar)), XmlInclude(typeof(TargetRetrieveAnnotation)), XmlInclude(typeof(TargetRetrieveActivityPointer)), XmlInclude(typeof(TargetRetrieveActivityMimeAttachment)), XmlInclude(typeof(TargetRetrieveAccount)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class TargetRetrieve
	{
	}
}
