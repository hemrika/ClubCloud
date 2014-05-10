using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(SetStateSgt_fac_buma_bijdrage_achtergrondmuziekRequest)), XmlInclude(typeof(RetrievePrincipalAccessRequest)), XmlInclude(typeof(SetStateKbArticleRequest)), XmlInclude(typeof(SetStateLetterRequest)), XmlInclude(typeof(SetStateLeadRequest)), XmlInclude(typeof(SetStateSgt_alg_baan_keuringRequest)), XmlInclude(typeof(WinOpportunityRequest)), XmlInclude(typeof(WhoAmIRequest)), XmlInclude(typeof(ValidateSavedQueryRequest)), XmlInclude(typeof(ValidateRequest)), XmlInclude(typeof(UtcTimeFromLocalTimeRequest)), XmlInclude(typeof(UpdateUserSettingsSystemUserRequest)), XmlInclude(typeof(UpdateRequest)), XmlInclude(typeof(UnregisterSolutionRequest)), XmlInclude(typeof(UnpublishDuplicateRuleRequest)), XmlInclude(typeof(UnlockSalesOrderPricingRequest)), XmlInclude(typeof(UnlockInvoicePricingRequest)), XmlInclude(typeof(TransformImportRequest)), XmlInclude(typeof(StatusUpdateBulkOperationRequest)), XmlInclude(typeof(SetStateWorkflowRequest)), XmlInclude(typeof(SetStateWFProcessInstanceRequest)), XmlInclude(typeof(SetStateUserQueryRequest)), XmlInclude(typeof(SetStateTransactionCurrencyRequest)), XmlInclude(typeof(SetStateTaskRequest)), XmlInclude(typeof(SetStateSystemUserRequest)), XmlInclude(typeof(SetStateSw_tracelogRequest)), XmlInclude(typeof(SetStateSw_retrievequeryRequest)), XmlInclude(typeof(SetStateSw_retrievemultiplequeryRequest)), XmlInclude(typeof(SetStateSw_picklistRequest)), XmlInclude(typeof(SetStateSw_lookupviewtranslationRequest)), XmlInclude(typeof(SetStateSw_lookuptemplateRequest)), XmlInclude(typeof(SetStateSw_lookuplabelsRequest)), XmlInclude(typeof(SetStateSw_lookupdefinitionRequest)), XmlInclude(typeof(SetStateSw_lookupcolumnRequest)), XmlInclude(typeof(SetStateSw_licenseRequest)), XmlInclude(typeof(SetStateSw_licensemanagerRequest)), XmlInclude(typeof(SetStateSgt_wt_opleidingsgroep_docentRequest)), XmlInclude(typeof(SetStateSgt_wt_opleidingsfaseRequest)), XmlInclude(typeof(SetStateSgt_wt_opleidingsfase_resultaatRequest)), XmlInclude(typeof(SetStateSgt_wt_inschrijfformulier_vcl_vtlRequest)), XmlInclude(typeof(SetStateSgt_top_tennissertypeRequest)), XmlInclude(typeof(SetStateSgt_top_soort_groepsevenementRequest)), XmlInclude(typeof(SetStateSgt_top_soort_groepRequest)), XmlInclude(typeof(SetStateSgt_top_groepsevenementRequest)), XmlInclude(typeof(SetStateSgt_top_groepsevenement_begeleidingRequest)), XmlInclude(typeof(SetStateSgt_top_groepsbegeleidingRequest)), XmlInclude(typeof(SetStateSgt_top_groepRequest)), XmlInclude(typeof(SetStateSgt_top_groep_deelnemersRequest)), XmlInclude(typeof(SetStateSgt_top_geselecteerd_tennisserRequest)), XmlInclude(typeof(SetStateSgt_top_begeleidingRequest)), XmlInclude(typeof(SetStateSgt_toe_zwaarteRequest)), XmlInclude(typeof(SetStateSgt_toe_zwaarte_op_toernooiniveauRequest)), XmlInclude(typeof(SetStateSgt_alg_lidmaatschapRequest)), XmlInclude(typeof(SetStateSgt_toe_wedstrijdschemaRequest)), XmlInclude(typeof(SetStateSgt_toe_uitzonderingsdagRequest)), XmlInclude(typeof(SetStateSgt_toe_type_ranglijstRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooispelerRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooisoortRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooischemaRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooischema_spelerRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooischema_per_schemagrootteRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooiRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooionderdeelRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooionderdeelgeneratorRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooionderdeel_ranglijstRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooikalenderRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooigroepRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooien_reglementaire_arbitrageRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooicircuitRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooiafhandelingRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooi_resultatenRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooi_op_toernooikalenderRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooi_in_interface_logboekRequest)), XmlInclude(typeof(SetStateSgt_toe_toernooi_aanvraagrechtRequest)), XmlInclude(typeof(SetStateSgt_toe_strafRequest)), XmlInclude(typeof(SetStateSgt_toe_spelersmemoRequest)), XmlInclude(typeof(SetStateSgt_toe_speelsterktecategorieRequest)), XmlInclude(typeof(SetStateSgt_toe_special_exemptRequest)), XmlInclude(typeof(SetStateSgt_toe_soortbalRequest)), XmlInclude(typeof(SetStateSgt_toe_schemasoortRequest)), XmlInclude(typeof(SetStateSgt_toe_schemagrootteRequest)), XmlInclude(typeof(SetStateSgt_toe_schemagrootte_per_toernooisoortRequest)), XmlInclude(typeof(SetStateSgt_toe_schaduw_ranglijst_logboekRequest)), XmlInclude(typeof(SetStateSgt_toe_ronde_pouleRequest)), XmlInclude(typeof(SetStateSgt_toe_reden_dispensatie_toernooibijdrageRequest)), XmlInclude(typeof(SetStateSgt_toe_reden_annuleren_toernooiRequest)), XmlInclude(typeof(SetStateSgt_toe_reden_afwijzing_toernooiRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijstRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijstpuntenRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijstpunten_toernooiresultaatRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijstpositieRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijstgroepRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijst_logboekRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijst_deelgetalRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijst_deelgetal_dubbelspelRequest)), XmlInclude(typeof(SetStateSgt_toe_ranglijst_bonuspuntenRequest)), XmlInclude(typeof(SetStateSgt_toe_prijzengeldRequest)), XmlInclude(typeof(SetStateSgt_toe_post_inRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutaute_inschrijfcontrole_verRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslagRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslag_toRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslag_teamRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslag_setRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslag_rondeRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslag_psRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslag_pouleRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooiuitslag_partijRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_mutatie_toernooidefinitieRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_interface_logboek_toernooienRequest)), XmlInclude(typeof(SetStateSgt_toe_pb_interface_logboek_toernooi_foutRequest)), XmlInclude(typeof(SetStateSgt_toe_partij_uitslag_toernooiRequest)), XmlInclude(typeof(SetStateSgt_toe_niet_knltb_ledenRequest)), XmlInclude(typeof(SetStateSgt_toe_leeftijdscategorieRequest)), XmlInclude(typeof(SetStateSgt_toe_leeftijdscat_aanvraagformulierRequest)), XmlInclude(typeof(SetStateSgt_toe_kwalificatiecodeRequest)), XmlInclude(typeof(SetStateSgt_toe_koppeltabel_post_naarRequest)), XmlInclude(typeof(SetStateSgt_toe_inschrijfrecht_spelerRequest)), XmlInclude(typeof(SetStateSgt_toe_inschrijfmethode_per_toernooisoortRequest)), XmlInclude(typeof(SetStateSgt_toe_inschrijf_functie_toernooisoortRequest)), XmlInclude(typeof(SetStateSgt_toe_dynamische_velden_per_toernooiRequest)), XmlInclude(typeof(SetStateSgt_toe_dagtoernooiRequest)), XmlInclude(typeof(SetStateSgt_toe_constaterings_moment_AORequest)), XmlInclude(typeof(SetStateSgt_toe_circuitranglijst_logboekRequest)), XmlInclude(typeof(SetStateSgt_toe_circuitpuntenRequest)), XmlInclude(typeof(SetStateSgt_toe_circuitpunten_toernooiresultaatRequest)), XmlInclude(typeof(SetStateSgt_toe_circuit_toernooionderdeelRequest)), XmlInclude(typeof(SetStateSgt_toe_circuit_deelgetalRequest)), XmlInclude(typeof(SetStateSgt_toe_circuit_bonuspuntenRequest)), XmlInclude(typeof(SetStateSgt_toe_bondsgedelegeerdeRequest)), XmlInclude(typeof(SetStateSgt_toe_bericht_inschrijving_verenigingRequest)), XmlInclude(typeof(SetStateSgt_toe_basisschemaRequest)), XmlInclude(typeof(SetStateSgt_toe_basisschema_rondeRequest)), XmlInclude(typeof(SetStateSgt_toe_basisschema_partijRequest)), XmlInclude(typeof(SetStateSgt_toe_baansoort_toernooiRequest)), XmlInclude(typeof(SetStateSgt_toe_automatische_acceptatie_van_spelersRequest)), XmlInclude(typeof(SetStateSgt_toe_afwijkende_verdeling_geboortejaarRequest)), XmlInclude(typeof(SetStateSgt_toe_afwezigheid_bondsgedelegeerdeRequest)), XmlInclude(typeof(SetStateSgt_toe_administratieve_overtredingRequest)), XmlInclude(typeof(SetStateSgt_toe_administratieve_overtreding_mutatieRequest)), XmlInclude(typeof(SetStateSgt_toe_administratieve_overtr_strafmaatRequest)), XmlInclude(typeof(SetStateSgt_toe_administratieve_overtr_strafbepalngRequest)), XmlInclude(typeof(SetStateSgt_toe_administratieve_overtr_beroepRequest)), XmlInclude(typeof(SetStateSgt_toe_administratieve_overtr_beroep_mutRequest)), XmlInclude(typeof(SetStateSgt_toe_accepteren_speler_toernooisoortRequest)), XmlInclude(typeof(SetStateSgt_toe_aanvraagformulierRequest)), XmlInclude(typeof(SetStateSgt_toe_aanvraagformulier_dagtoernooiRequest)), XmlInclude(typeof(SetStateSgt_smp_sitemap_toegang_wlRequest)), XmlInclude(typeof(SetStateSgt_smp_sitemap_toegang_vclRequest)), XmlInclude(typeof(SetStateSgt_smp_sitemap_toegang_ledRequest)), XmlInclude(typeof(SetStateSgt_smp_sitemap_toegang_knltbRequest)), XmlInclude(typeof(SetStateSgt_smp_sitemap_toegang_capRequest)), XmlInclude(typeof(SetStateSgt_smp_sitemap_toegang_bgdRequest)), XmlInclude(typeof(SetStateSgt_smp_sitemap_toegang_afRequest)), XmlInclude(typeof(SetStateSgt_rol_verbergen_tabbladen_sectiesRequest)), XmlInclude(typeof(SetStateSgt_rol_verbergen_entiteitRequest)), XmlInclude(typeof(SetStateSgt_pbmutatietoernooidefinitieonderdeelRequest)), XmlInclude(typeof(SetStateSgt_logboek_ecampus_resultaten_meldingRequest)), XmlInclude(typeof(SetStateSgt_functieperbestuursorgaanRequest)), XmlInclude(typeof(SetStateSgt_fac_factuurverzamelingRequest)), XmlInclude(typeof(SetStateSgt_fac_factuurgroepRequest)), XmlInclude(typeof(SetStateSgt_fac_factuurgroep_toernooisoortRequest)), XmlInclude(typeof(SetStateSgt_fac_factuur_typeRequest)), XmlInclude(typeof(SetStateSgt_fac_factuur_type_factuurregelRequest)), XmlInclude(typeof(SetStateSgt_fac_factuur_mutatieRequest)), XmlInclude(typeof(SetStateSgt_fac_buma_soort_apparatuurRequest)), XmlInclude(typeof(SetStateSgt_fac_buma_bijdrage_amusementsmuziekRequest)), XmlInclude(typeof(SetStateSgt_dynamiclookupRequest)), XmlInclude(typeof(SetStateSgt_dynamicformRequest)), XmlInclude(typeof(SetStateSgt_dynamicformfieldRequest)), XmlInclude(typeof(SetStateSgt_dynamicformentityRequest)), XmlInclude(typeof(SetStateSgt_dss_variabelen_dssRequest)), XmlInclude(typeof(SetStateSgt_dss_tussentijdse_ratingRequest)), XmlInclude(typeof(SetStateSgt_dss_tussentijdse_rating_peildatumRequest)), XmlInclude(typeof(SetStateSgt_dss_tussentijdse_rating_logboekRequest)), XmlInclude(typeof(SetStateSgt_dss_spelersprofielRequest)), XmlInclude(typeof(SetStateSgt_dss_speelsterkteRequest)), XmlInclude(typeof(SetStateSgt_dss_speelsterktemutatieRequest)), XmlInclude(typeof(SetStateSgt_dss_speelsterktemutatie_afhandelingRequest)), XmlInclude(typeof(SetStateSgt_dss_speelsterktemutatie_aanvraagRequest)), XmlInclude(typeof(SetStateSgt_dss_speelsterktemut_reden_toe_afwijzingRequest)), XmlInclude(typeof(SetStateSgt_dss_reden_speelsterktemutatieRequest)), XmlInclude(typeof(SetStateSgt_dss_ratingmutatieRequest)), XmlInclude(typeof(SetStateSgt_dss_ratinglogboekRequest)), XmlInclude(typeof(SetStateSgt_dss_partijresultaatRequest)), XmlInclude(typeof(SetStateSgt_dss_irreele_rs_mutatieRequest)), XmlInclude(typeof(SetStateSgt_dss_Irreele_rs_logboekRequest)), XmlInclude(typeof(SetStateSgt_dss_grenswaarden_speelsterkteRequest)), XmlInclude(typeof(SetStateSgt_dss_eindejaarsratingRequest)), XmlInclude(typeof(SetStateSgt_dss_correctiewaarde_basisgetalRequest)), XmlInclude(typeof(SetStateSgt_com_wedstrijdgegevensRequest)), XmlInclude(typeof(SetStateSgt_com_wedstrijd_uitslag_mutatieRequest)), XmlInclude(typeof(SetStateSgt_com_verenigingsrechtRequest)), XmlInclude(typeof(SetStateSgt_com_verenigingsdispensatieRequest)), XmlInclude(typeof(SetStateSgt_com_uitnodiging_mutatieRequest)), XmlInclude(typeof(SetStateSgt_com_tussenstand_afdeling_logboekRequest)), XmlInclude(typeof(SetStateSgt_com_toeslag_inschrijfbijdrageRequest)), XmlInclude(typeof(SetStateSgt_com_toegepast_speelschemaRequest)), XmlInclude(typeof(SetStateSgt_com_thuis_thuis_schemaRequest)), XmlInclude(typeof(SetStateSgt_com_spelersdispensatieRequest)), XmlInclude(typeof(SetStateSgt_com_speelschema_wedstrijdRequest)), XmlInclude(typeof(SetStateSgt_com_speelschema_tegenovergesteldRequest)), XmlInclude(typeof(SetStateSgt_com_speelschema_standaardRequest)), XmlInclude(typeof(SetStateSgt_com_reeks_speeldatumsRequest)), XmlInclude(typeof(SetStateSgt_com_reden_niet_gespeeldRequest)), XmlInclude(typeof(SetStateSgt_com_protest_mutatieRequest)), XmlInclude(typeof(SetStateSgt_com_ploegtoevoegingRequest)), XmlInclude(typeof(SetStateSgt_com_ploegsamenstellingRequest)), XmlInclude(typeof(SetStateSgt_com_ploegRequest)), XmlInclude(typeof(SetStateSgt_com_ploegopgaveRequest)), XmlInclude(typeof(SetStateSgt_com_ploegnaam_mutatieRequest)), XmlInclude(typeof(SetStateSgt_com_ploegmutatieRequest)), XmlInclude(typeof(SetStateSgt_com_ploeginschrijvingRequest)), XmlInclude(typeof(SetStateSgt_com_ploeginschrijving_afhandelingRequest)), XmlInclude(typeof(SetStateSgt_com_piramideRequest)), XmlInclude(typeof(SetStateSgt_com_partij_uitslagRequest)), XmlInclude(typeof(SetStateSgt_com_partij_uitslag_mutatieRequest)), XmlInclude(typeof(SetStateSgt_com_klassevolgordeRequest)), XmlInclude(typeof(SetStateSgt_com_klasseRequest)), XmlInclude(typeof(SetStateSgt_com_klassegroepRequest)), XmlInclude(typeof(SetStateSgt_com_kalenderRequest)), XmlInclude(typeof(SetStateSgt_com_inschrijfbijdrageRequest)), XmlInclude(typeof(SetStateSgt_com_ingedeelde_ploegRequest)), XmlInclude(typeof(SetStateSgt_com_deelname_niet_knltb_lidRequest)), XmlInclude(typeof(SetStateSgt_com_controle_dispensatieRequest)), XmlInclude(typeof(SetStateSgt_com_controle_dispensatie_logboekRequest)), XmlInclude(typeof(SetStateSgt_com_competitietypeRequest)), XmlInclude(typeof(SetStateSgt_com_competitiesoortRequest)), XmlInclude(typeof(SetStateSgt_com_competitieRequest)), XmlInclude(typeof(SetStateSgt_com_competitierechtRequest)), XmlInclude(typeof(SetStateSgt_com_competitieinschrijvingRequest)), XmlInclude(typeof(SetStateSgt_com_competitiegedelegeerdeRequest)), XmlInclude(typeof(SetStateSgt_com_competitie_indelingRequest)), XmlInclude(typeof(SetStateSgt_com_competitie_districtsselectieRequest)), XmlInclude(typeof(SetStateSgt_com_competitie_afsluitingRequest)), XmlInclude(typeof(SetStateSgt_com_bezoek_consulRequest)), XmlInclude(typeof(SetStateSgt_com_beslissingswedstrijdRequest)), XmlInclude(typeof(SetStateSgt_com_baan_gereserveerd_competitieRequest)), XmlInclude(typeof(SetStateSgt_com_afdelingRequest)), XmlInclude(typeof(SetStateSgt_bo_vooropleidingRequest)), XmlInclude(typeof(SetStateSgt_bo_voorkeur_testdagRequest)), XmlInclude(typeof(SetStateSgt_bo_voorkeur_opleidingsgroepRequest)), XmlInclude(typeof(SetStateSgt_bo_testdagRequest)), XmlInclude(typeof(SetStateSgt_bo_tennisleraarRequest)), XmlInclude(typeof(SetStateSgt_bo_tennisleraar_geeft_les_bijRequest)), XmlInclude(typeof(SetStateSgt_bo_soort_examenRequest)), XmlInclude(typeof(SetStateSgt_bo_opleidingsgroepRequest)), XmlInclude(typeof(SetStateSgt_bo_opleidingRequest)), XmlInclude(typeof(SetStateSgt_bo_logboek_VNTRequest)), XmlInclude(typeof(SetStateSgt_bo_logboek_vnt_meldingRequest)), XmlInclude(typeof(SetStateSgt_bo_logboek_ecampus_resultatenRequest)), XmlInclude(typeof(SetStateSgt_bo_licentiesoortRequest)), XmlInclude(typeof(SetStateSgt_bo_licentieaanvraagRequest)), XmlInclude(typeof(SetStateSgt_bo_licentie_logboekRequest)), XmlInclude(typeof(SetStateSgt_bo_inschrijfformulier_testdagRequest)), XmlInclude(typeof(SetStateSgt_bo_gewijzigde_persoonsgegevensRequest)), XmlInclude(typeof(SetStateSgt_bo_examenRequest)), XmlInclude(typeof(SetStateSgt_bo_cursistRequest)), XmlInclude(typeof(SetStateSgt_bo_cursist_examenRequest)), XmlInclude(typeof(SetStateSgt_autorisatie_uitgifteRequest)), XmlInclude(typeof(SetStateSgt_autorisatie_padenRequest)), XmlInclude(typeof(SetStateSgt_autorisatie_entity_per_teamRequest)), XmlInclude(typeof(SetStateSgt_autorisatie_entiteit_gekoppeldRequest)), XmlInclude(typeof(SetStateSgt_arbitrage_inzet_per_dagRequest)), XmlInclude(typeof(SetStateSgt_arb_sps_strafRequest)), XmlInclude(typeof(SetStateSgt_arb_sps_formulierRequest)), XmlInclude(typeof(SetStateSgt_arb_rapport_hoofdscheidsrechterRequest)), XmlInclude(typeof(SetStateSgt_arb_beschikbaarheid_toernooi_per_dagRequest)), XmlInclude(typeof(SetStateSgt_arb_beschikbaarheid_competitieRequest)), XmlInclude(typeof(SetStateSgt_arb_beoordeling_arbitragefunctionarisRequest)), XmlInclude(typeof(SetStateSgt_arb_behoefte_per_competitiewedstrijdRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitragedagRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitragebeschikbaarheid_toernooiRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitragebehoefte_toernooienRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitragebehoefte_toernooi_per_dagRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitragebehoefte_competitieRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitrage_inzet_toernooienRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitrage_inzet_competitieRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitrage_indeling_toernooiRequest)), XmlInclude(typeof(SetStateSgt_arb_arbitrage_functionarisRequest)), XmlInclude(typeof(SetStateSgt_alg_workflow_timestampRequest)), XmlInclude(typeof(SetStateSgt_alg_vrij_bondsnummerRequest)), XmlInclude(typeof(SetStateSgt_alg_virtueelteamRequest)), XmlInclude(typeof(SetStateSgt_alg_verzendwijzeRequest)), XmlInclude(typeof(SetStateSgt_alg_type_bestuursorgaanRequest)), XmlInclude(typeof(SetStateSgt_alg_toplaagRequest)), XmlInclude(typeof(SetStateSgt_alg_telmethodeRequest)), XmlInclude(typeof(SetStateSgt_alg_team_bij_functieRequest)), XmlInclude(typeof(SetStateSgt_alg_speciale_baanRequest)), XmlInclude(typeof(SetStateSgt_alg_soort_verlichtingRequest)), XmlInclude(typeof(RetrieveProvisionedLanguagesRequest)), XmlInclude(typeof(SetStateSgt_alg_soort_abonnementRequest)), XmlInclude(typeof(SetStateSgt_alg_servit1_contacthistorieRequest)), XmlInclude(typeof(SetStateSgt_alg_schorsingRequest)), XmlInclude(typeof(SetStateSgt_alg_rol_pers_relatieRequest)), XmlInclude(typeof(SetStateSgt_alg_rol_bij_functieRequest)), XmlInclude(typeof(SetStateSgt_alg_reset_passwordRequest)), XmlInclude(typeof(SetStateSgt_alg_reisafstandRequest)), XmlInclude(typeof(SetStateSgt_alg_reden_afgekeurdRequest)), XmlInclude(typeof(SetStateSgt_alg_record_lockRequest)), XmlInclude(typeof(SetStateSgt_alg_record_lock_maintenanceRequest)), XmlInclude(typeof(SetStateSgt_alg_rechtsvormRequest)), XmlInclude(typeof(SetStateSgt_alg_postcodeRequest)), XmlInclude(typeof(SetStateSgt_alg_postcode_importRequest)), XmlInclude(typeof(SetStateSgt_alg_persoonlijke_relatieRequest)), XmlInclude(typeof(SetStateSgt_alg_periodiek_procesRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_mutatie_verenigingsinformatieRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_mutatie_ledenRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_mutatie_functionarissenRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_mutatie_accommodatiesRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_interfaceRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_interface_logboekRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_interface_logboek_logbestandRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_interface_logboek_leden_importRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_interface_logboek_leden_exportRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_interface_logboek_import_xmlRequest)), XmlInclude(typeof(SetStateSgt_alg_pb_interface_logboek_export_xmlRequest)), XmlInclude(typeof(SetStateSgt_alg_pastypeRequest)), XmlInclude(typeof(SetStateSgt_alg_pasfoto_bulkimport_logboekRequest)), XmlInclude(typeof(SetStateSgt_alg_onderwerp_activiteitRequest)), XmlInclude(typeof(SetStateSgt_alg_occ_enabled_entityRequest)), XmlInclude(typeof(SetStateSgt_alg_nummerreeksRequest)), XmlInclude(typeof(SetStateSgt_alg_nummerreeks_uitgaveRequest)), XmlInclude(typeof(SetStateSgt_alg_nationaliteitRequest)), XmlInclude(typeof(SetStateSgt_alg_melding_maatwerkRequest)), XmlInclude(typeof(SetStateSgt_alg_lookupcontrol_filterRequest)), XmlInclude(typeof(SetStateSgt_alg_logboek_ledenpas_retourRequest)), XmlInclude(typeof(SetStateSgt_alg_logboek_ledenpas_een_berichtRequest)), XmlInclude(typeof(SetStateSgt_alg_logboek_ledenpas_bericht_per_verRequest)), XmlInclude(typeof(SetStateSgt_alg_logboek_fact_import_betalingenRequest)), XmlInclude(typeof(SetStateSgt_alg_logboek_fact_export_facturenRequest)), XmlInclude(typeof(SetStateSgt_alg_logboek_fact_export_debiteurenRequest)), XmlInclude(typeof(SetStateSgt_alg_logboek_dcpRequest)), XmlInclude(typeof(SetStateSgt_alg_liggingkenmerkRequest)), XmlInclude(typeof(SetStateSgt_alg_lidmaatschappen_omhangenRequest)), XmlInclude(typeof(SetStateSgt_alg_leveringsconditieRequest)), XmlInclude(typeof(SetStateSgt_alg_ledenpas_verenigingRequest)), XmlInclude(typeof(SetStateSgt_alg_ledenpas_logboekRequest)), XmlInclude(typeof(SetStateSgt_alg_ledenpas_lidRequest)), XmlInclude(typeof(SetStateSgt_alg_landcodeRequest)), XmlInclude(typeof(SetStateSgt_alg_kvk_plaatsRequest)), XmlInclude(typeof(SetStateSgt_alg_kvk_brancheRequest)), XmlInclude(typeof(SetStateSgt_alg_kenmerkRequest)), XmlInclude(typeof(SetStateSgt_alg_inschrijf_functie_gebeurtenistypeRequest)), XmlInclude(typeof(SetStateSgt_alg_IDEAL_betalingRequest)), XmlInclude(typeof(SetStateSgt_alg_ideal_betaling_gebeurtenisRequest)), XmlInclude(typeof(SetStateSgt_alg_grootboekcodeRequest)), XmlInclude(typeof(SetStateSgt_alg_gebeurtenistypeRequest)), XmlInclude(typeof(SetStateSgt_alg_gebeurtenisRequest)), XmlInclude(typeof(SetStateSgt_alg_gebeurtenisgespreksonderwerpRequest)), XmlInclude(typeof(SetStateSgt_alg_gebeurtenis_beinvloederrolRequest)), XmlInclude(typeof(SetStateSgt_alg_gebeurtenis_beinvloederRequest)), XmlInclude(typeof(SetStateSgt_alg_functionele_logRequest)), XmlInclude(typeof(SetStateSgt_alg_functionarisRequest)), XmlInclude(typeof(SetStateSgt_alg_functieRequest)), XmlInclude(typeof(SetStateSgt_alg_formulier_met_idealRequest)), XmlInclude(typeof(SetStateSgt_alg_formulier_antwoordRequest)), XmlInclude(typeof(SetStateSgt_alg_formulier_antwoord_veldRequest)), XmlInclude(typeof(SetStateSgt_alg_flexibel_kenmerkRequest)), XmlInclude(typeof(SetStateSgt_alg_flexibel_kenmerk_typeRequest)), XmlInclude(typeof(SetStateSgt_alg_factuur_logboekRequest)), XmlInclude(typeof(SetStateSgt_alg_email_samenvoegveldRequest)), XmlInclude(typeof(SetStateSgt_alg_districtRequest)), XmlInclude(typeof(SetStateSgt_alg_custom_configRequest)), XmlInclude(typeof(SetStateSgt_alg_competentieRequest)), XmlInclude(typeof(SetStateSgt_alg_certificaatRequest)), XmlInclude(typeof(SetStateSgt_alg_certificaat_typeRequest)), XmlInclude(typeof(SetStateSgt_alg_btw_codeRequest)), XmlInclude(typeof(SetStateSgt_alg_bouwaardRequest)), XmlInclude(typeof(SetStateSgt_alg_boetesRequest)), XmlInclude(typeof(SetStateSgt_alg_betalingsvoorwaardeRequest)), XmlInclude(typeof(SetStateSgt_alg_bestuursorgaanRequest)), XmlInclude(typeof(SetStateSgt_alg_baantypeRequest)), XmlInclude(typeof(SetStateSgt_alg_baansoortRequest)), XmlInclude(typeof(SetStateSgt_alg_baanRequest)), XmlInclude(typeof(SetStateSgt_alg_baanblokRequest)), XmlInclude(typeof(SetStateSgt_alg_baanblok_werkzaamheidRequest)), XmlInclude(typeof(SetStateSgt_alg_baan_gereserveerdRequest)), XmlInclude(typeof(SetStateSgt_alg_baan_gereserveerd_verenigingRequest)), XmlInclude(typeof(SetStateSgt_alg_administratieRequest)), XmlInclude(typeof(SetStateSgt_alg_ad_groepRequest)), XmlInclude(typeof(SetStateSgt_alg_ad_groep_bij_functieRequest)), XmlInclude(typeof(SetStateSgt_alg_activiteitenplanRequest)), XmlInclude(typeof(SetStateSgt_alg_accommodatieRequest)), XmlInclude(typeof(SetStateSgt_alg_abonneeRequest)), XmlInclude(typeof(SetStateServiceAppointmentRequest)), XmlInclude(typeof(SetStateSdkMessageProcessingStepRequest)), XmlInclude(typeof(SetStateSalesOrderRequest)), XmlInclude(typeof(SetStateRelationshipRoleRequest)), XmlInclude(typeof(SetStateQuoteRequest)), XmlInclude(typeof(SetStateQuoteCloseRequest)), XmlInclude(typeof(SetStateProductRequest)), XmlInclude(typeof(SetStatePriceLevelRequest)), XmlInclude(typeof(SetStatePhoneCallRequest)), XmlInclude(typeof(SetStateOrderCloseRequest)), XmlInclude(typeof(SetStateOpportunityRequest)), XmlInclude(typeof(SetStateOpportunityCloseRequest)), XmlInclude(typeof(SetStateMailMergeTemplateRequest)), XmlInclude(typeof(SetStateListRequest)), XmlInclude(typeof(WinQuoteRequest)), XmlInclude(typeof(SetStateSgt_toe_wildcardRequest)), XmlInclude(typeof(SetStateInvoiceRequest)), XmlInclude(typeof(SetStateIncidentResolutionRequest)), XmlInclude(typeof(SetStateIncidentRequest)), XmlInclude(typeof(SetStateImportMapRequest)), XmlInclude(typeof(SetStateGi_FieldLevelSecurityRequest)), XmlInclude(typeof(SetStateFaxRequest)), XmlInclude(typeof(SetStateEmailRequest)), XmlInclude(typeof(SetStateDynamicEntityRequest)), XmlInclude(typeof(SetStateDiscountTypeRequest)), XmlInclude(typeof(SetStateContractRequest)), XmlInclude(typeof(SetStateContractDetailRequest)), XmlInclude(typeof(SetStateContactRequest)), XmlInclude(typeof(SetStateCampaignResponseRequest)), XmlInclude(typeof(SetStateCampaignRequest)), XmlInclude(typeof(SetStateCampaignActivityRequest)), XmlInclude(typeof(SetStateBusinessUnitRequest)), XmlInclude(typeof(SetStateAppointmentRequest)), XmlInclude(typeof(SetStateAccountRequest)), XmlInclude(typeof(SetReportRelatedRequest)), XmlInclude(typeof(SetRelatedRequest)), XmlInclude(typeof(SetParentTeamRequest)), XmlInclude(typeof(SetParentSystemUserRequest)), XmlInclude(typeof(SetParentBusinessUnitRequest)), XmlInclude(typeof(SetLocLabelsRequest)), XmlInclude(typeof(SetBusinessSystemUserRequest)), XmlInclude(typeof(SetBusinessEquipmentRequest)), XmlInclude(typeof(SendTemplateRequest)), XmlInclude(typeof(SendFaxRequest)), XmlInclude(typeof(SendEmailRequest)), XmlInclude(typeof(SendEmailFromTemplateRequest)), XmlInclude(typeof(SendBulkMailRequest)), XmlInclude(typeof(SearchRequest)), XmlInclude(typeof(SearchByTitleKbArticleRequest)), XmlInclude(typeof(SearchByKeywordsKbArticleRequest)), XmlInclude(typeof(SearchByBodyKbArticleRequest)), XmlInclude(typeof(RouteRequest)), XmlInclude(typeof(RollupRequest)), XmlInclude(typeof(RevokeAccessRequest)), XmlInclude(typeof(ReviseQuoteRequest)), XmlInclude(typeof(RetrieveVersionRequest)), XmlInclude(typeof(RetrieveUserSettingsSystemUserRequest)), XmlInclude(typeof(RetrieveUserPrivilegesRequest)), XmlInclude(typeof(RetrieveTeamsSystemUserRequest)), XmlInclude(typeof(RetrieveSubsidiaryUsersBusinessUnitRequest)), XmlInclude(typeof(RetrieveSubsidiaryTeamsBusinessUnitRequest)), XmlInclude(typeof(RetrieveSubGroupsResourceGroupRequest)), XmlInclude(typeof(RetrieveSharedPrincipalsAndAccessRequest)), XmlInclude(typeof(RetrieveRolePrivilegesRoleRequest)), XmlInclude(typeof(RetrieveRequest)), XmlInclude(typeof(GetReportHistoryLimitRequest)), XmlInclude(typeof(RetrievePrivilegeSetRequest)), XmlInclude(typeof(SetStateSgt_alg_soort_lidmaatschapRequest)), XmlInclude(typeof(RetrieveParsedDataImportFileRequest)), XmlInclude(typeof(RetrieveParentGroupsResourceGroupRequest)), XmlInclude(typeof(RetrieveMultipleRequest)), XmlInclude(typeof(RetrieveMembersTeamRequest)), XmlInclude(typeof(RetrieveMembersBulkOperationRequest)), XmlInclude(typeof(RetrieveLocLabelsRequest)), XmlInclude(typeof(RetrieveLicenseInfoRequest)), XmlInclude(typeof(RetrieveInstalledLanguagePacksRequest)), XmlInclude(typeof(RetrieveFormXmlRequest)), XmlInclude(typeof(RetrieveExchangeRateRequest)), XmlInclude(typeof(RetrieveDuplicatesRequest)), XmlInclude(typeof(RetrieveDeprovisionedLanguagesRequest)), XmlInclude(typeof(RetrieveDeploymentLicenseTypeRequest)), XmlInclude(typeof(RetrieveByTopIncidentSubjectKbArticleRequest)), XmlInclude(typeof(RetrieveByTopIncidentProductKbArticleRequest)), XmlInclude(typeof(RetrieveByResourcesServiceRequest)), XmlInclude(typeof(RetrieveByResourceResourceGroupRequest)), XmlInclude(typeof(RetrieveByGroupResourceRequest)), XmlInclude(typeof(RetrieveBusinessHierarchyBusinessUnitRequest)), XmlInclude(typeof(RetrieveAvailableLanguagesRequest)), XmlInclude(typeof(RetrieveAllChildUsersSystemUserRequest)), XmlInclude(typeof(ResetDataFiltersRequest)), XmlInclude(typeof(RescheduleRequest)), XmlInclude(typeof(ReplacePrivilegesRoleRequest)), XmlInclude(typeof(RenewContractRequest)), XmlInclude(typeof(RemoveUserRolesRoleRequest)), XmlInclude(typeof(RemoveSubstituteProductRequest)), XmlInclude(typeof(RemoveRelatedRequest)), XmlInclude(typeof(RemoveProductFromKitRequest)), XmlInclude(typeof(RemovePrivilegeRoleRequest)), XmlInclude(typeof(RemoveParentRequest)), XmlInclude(typeof(RemoveMembersTeamRequest)), XmlInclude(typeof(RemoveMemberListRequest)), XmlInclude(typeof(RemoveItemCampaignRequest)), XmlInclude(typeof(RemoveItemCampaignActivityRequest)), XmlInclude(typeof(RegisterSolutionRequest)), XmlInclude(typeof(ReassignObjectsSystemUserRequest)), XmlInclude(typeof(QueryScheduleRequest)), XmlInclude(typeof(QueryMultipleSchedulesRequest)), XmlInclude(typeof(QueryExpressionToFetchXmlRequest)), XmlInclude(typeof(QualifyMemberListRequest)), XmlInclude(typeof(PublishXmlRequest)), XmlInclude(typeof(PublishDuplicateRuleRequest)), XmlInclude(typeof(PublishAllXmlRequest)), XmlInclude(typeof(PropagateByExpressionRequest)), XmlInclude(typeof(ProcessOneMemberBulkOperationRequest)), XmlInclude(typeof(ProcessInboundEmailRequest)), XmlInclude(typeof(ParseImportRequest)), XmlInclude(typeof(ModifyAccessRequest)), XmlInclude(typeof(MergeRequest)), XmlInclude(typeof(MakeUnavailableToOrganizationTemplateRequest)), XmlInclude(typeof(MakeUnavailableToOrganizationReportRequest)), XmlInclude(typeof(MakeAvailableToOrganizationTemplateRequest)), XmlInclude(typeof(MakeAvailableToOrganizationReportRequest)), XmlInclude(typeof(LoseOpportunityRequest)), XmlInclude(typeof(LogSuccessBulkOperationRequest)), XmlInclude(typeof(LogFailureBulkOperationRequest)), XmlInclude(typeof(LockSalesOrderPricingRequest)), XmlInclude(typeof(LockInvoicePricingRequest)), XmlInclude(typeof(LocalTimeFromUtcTimeRequest)), XmlInclude(typeof(IsValidStateTransitionRequest)), XmlInclude(typeof(IsBackOfficeInstalledRequest)), XmlInclude(typeof(InstantiateTemplateRequest)), XmlInclude(typeof(InitializeFromRequest)), XmlInclude(typeof(ImportXmlWithProgressRequest)), XmlInclude(typeof(ImportXmlRequest)), XmlInclude(typeof(ImportTranslationsXmlWithProgressRequest)), XmlInclude(typeof(ImportRecordsImportRequest)), XmlInclude(typeof(ImportCompressedXmlWithProgressRequest)), XmlInclude(typeof(ImportCompressedTranslationsXmlWithProgressRequest)), XmlInclude(typeof(ImportCompressedAllXmlRequest)), XmlInclude(typeof(ImportAllXmlRequest)), XmlInclude(typeof(HandleRequest)), XmlInclude(typeof(GrantAccessRequest)), XmlInclude(typeof(GetTrackingTokenEmailRequest)), XmlInclude(typeof(GetTimeZoneCodeByLocalizedNameRequest)), XmlInclude(typeof(GetSalesOrderProductsFromOpportunityRequest)), XmlInclude(typeof(ConvertProductToKitRequest)), XmlInclude(typeof(GetQuoteProductsFromOpportunityRequest)), XmlInclude(typeof(GetQuantityDecimalRequest)), XmlInclude(typeof(GetInvoiceProductsFromOpportunityRequest)), XmlInclude(typeof(GetHeaderColumnsImportFileRequest)), XmlInclude(typeof(GetDistinctValuesImportFileRequest)), XmlInclude(typeof(GetDecryptionKeyRequest)), XmlInclude(typeof(GetAllTimeZonesWithDisplayNameRequest)), XmlInclude(typeof(GenerateSalesOrderFromOpportunityRequest)), XmlInclude(typeof(GenerateQuoteFromOpportunityRequest)), XmlInclude(typeof(GenerateInvoiceFromOpportunityRequest)), XmlInclude(typeof(FulfillSalesOrderRequest)), XmlInclude(typeof(FindParentResourceGroupRequest)), XmlInclude(typeof(FetchXmlToQueryExpressionRequest)), XmlInclude(typeof(ExportXmlRequest)), XmlInclude(typeof(ExportTranslationsXmlRequest)), XmlInclude(typeof(ExportCompressedXmlRequest)), XmlInclude(typeof(ExportCompressedTranslationsXmlRequest)), XmlInclude(typeof(ExportCompressedAllXmlRequest)), XmlInclude(typeof(ExportAllXmlRequest)), XmlInclude(typeof(ExpandCalendarRequest)), XmlInclude(typeof(ExecuteWorkflowRequest)), XmlInclude(typeof(ExecuteFetchRequest)), XmlInclude(typeof(ExecuteCampaignActivityRequest)), XmlInclude(typeof(ExecuteByIdUserQueryRequest)), XmlInclude(typeof(ExecuteByIdSavedQueryRequest)), XmlInclude(typeof(DownloadReportDefinitionRequest)), XmlInclude(typeof(DistributeCampaignActivityRequest)), XmlInclude(typeof(DisassociateEntitiesRequest)), XmlInclude(typeof(DetachFromQueueEmailRequest)), XmlInclude(typeof(DeliverPromoteEmailRequest)), XmlInclude(typeof(DeliverIncomingEmailRequest)), XmlInclude(typeof(DeleteRequest)), XmlInclude(typeof(CreateWorkflowFromTemplateRequest)), XmlInclude(typeof(CreateRequest)), XmlInclude(typeof(CreateActivitiesListRequest)), XmlInclude(typeof(CopyMembersListRequest)), XmlInclude(typeof(CopyCampaignRequest)), XmlInclude(typeof(ConvertSalesOrderToInvoiceRequest)), XmlInclude(typeof(ConvertQuoteToSalesOrderRequest)), XmlInclude(typeof(AutoMapEntityRequest)), XmlInclude(typeof(ConvertKitToProductRequest)), XmlInclude(typeof(CompoundUpdateRequest)), XmlInclude(typeof(CompoundUpdateDuplicateDetectionRuleRequest)), XmlInclude(typeof(CompoundCreateRequest)), XmlInclude(typeof(CloseQuoteRequest)), XmlInclude(typeof(CloseIncidentRequest)), XmlInclude(typeof(CloneContractRequest)), XmlInclude(typeof(CleanUpBulkOperationRequest)), XmlInclude(typeof(CheckPromoteEmailRequest)), XmlInclude(typeof(CheckIncomingEmailRequest)), XmlInclude(typeof(CancelSalesOrderRequest)), XmlInclude(typeof(CancelContractRequest)), XmlInclude(typeof(CalculateTotalTimeIncidentRequest)), XmlInclude(typeof(CalculateActualValueOpportunityRequest)), XmlInclude(typeof(BulkOperationStatusCloseRequest)), XmlInclude(typeof(BulkDetectDuplicatesRequest)), XmlInclude(typeof(BulkDeleteRequest)), XmlInclude(typeof(BookRequest)), XmlInclude(typeof(BackgroundSendEmailRequest)), XmlInclude(typeof(AddItemCampaignActivityRequest)), XmlInclude(typeof(AssociateEntitiesRequest)), XmlInclude(typeof(AssignUserRolesRoleRequest)), XmlInclude(typeof(AssignRequest)), XmlInclude(typeof(AddSubstituteProductRequest)), XmlInclude(typeof(AddProductToKitRequest)), XmlInclude(typeof(AddPrivilegesRoleRequest)), XmlInclude(typeof(AddMembersTeamRequest)), XmlInclude(typeof(AddMemberListRequest)), XmlInclude(typeof(AddItemCampaignRequest)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class Request
	{
		private OptionalParameter[] optionalParametersField;
		public OptionalParameter[] OptionalParameters
		{
			get
			{
				return this.optionalParametersField;
			}
			set
			{
				this.optionalParametersField = value;
			}
		}
	}
}
