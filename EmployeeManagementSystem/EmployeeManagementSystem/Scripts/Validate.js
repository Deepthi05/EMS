isNotDoubleClick = function () {
    if (typeof (_savedClicked) == "undefined") _savedClicked = true;
    setTimeout("blockClick()", 100);
    return _savedClicked;
}
blockClick = function () {
    _savedClicked = false;
    setTimeout("_savedClicked=true", 1000);
}



//All Error Messages.
function ClearErrorMsg() {

    document.getElementById("liPromotionName").className = "hideText";
    document.getElementById("liPromotionNameReg").className = "hideText";
    document.getElementById("liPromotionQualification").className = "hideText";
    document.getElementById("liMarketingObjectives").className = "hideText";
    document.getElementById("liSalesOrg").className = "hideText";
    document.getElementById("liMarketingObjectives").className = "hideText";
    document.getElementById("liPromotionObjectives").className = "hideText";
    document.getElementById("liPromotionMechanics").className = "hideText";
    document.getElementById("liPromotionPost_EndDate").className = "hideText";
    document.getElementById("liEndDateNotExistInTimeHierarchy").className = "hideText";
    document.getElementById("liStartDateNotExistInTimeHierarchy").className = "hideText";
    document.getElementById("liNote").className = "hideText";
    document.getElementById("liNoteReg").className = "hideText";
    document.getElementById("liAttachments").className = "hideText";
    document.getElementById("liPromotionStartDate").className = "hideText";
    document.getElementById("liPromotionStartEndDate").className = "hideText";
    document.getElementById("liPromotionEndDate").className = "hideText";
    document.getElementById("liPromotionSell_outStartDate").className = "hideText";
    document.getElementById("liPromotionSell_outStartDate_withoutConfig").className = "hideText";
    document.getElementById("liPromotionPre_StartDate").className = "hideText";
    document.getElementById("liDuration").className = "hideText";
    document.getElementById("liCrossYearDuration").className = "hideText";
    document.getElementById("liFileLimit").className = "hideText";
    document.getElementById("liRemoveAttach").className = "hideText";
    document.getElementById("liTxtNoteExceed").className = "hideText";
    document.getElementById("liSameFileName").className = "hideText";
    document.getElementById("liPreMinDate").className = "hideText";
    document.getElementById("liPostMaxDate").className = "hideText";
    document.getElementById("liMaxDate").className = "hideText";
    document.getElementById("liSellOutEndDateDoesntExist").className = "hideText";
    document.getElementById("liSellOutEndDateCrossYear").className = "hideText";
    document.getElementById("plErrorMessages").className = "hideText";
    document.getElementById("liSelectedDateDoesNotExist").className = "hideText";
    document.getElementById("liPromotionSell_outEndDate").className = "hideText";
    document.getElementById("liPromotionStartDateElapsed").className = "hideText";
    document.getElementById("liFileExtension").className = "hideText";
    document.getElementById("liNoFileSelected").className = "hideText";
    document.getElementById("liPlanningEntityStartDate").className = "hideText";
    document.getElementById("liPlanningEntityEndDate").className = "hideText";
    document.getElementById("liPlanningEntityMandatory").className = "hideText";
    document.getElementById("liPlanningEntityPreStartDate").className = "hideText";
    document.getElementById("liPlanningEntityPostEndDate").className = "hideText";
    document.getElementById("liSelectBundle").className = "hideText";
    document.getElementById("liBundleNotActive").className = "hideText";
    document.getElementById("liInvalidPromotionStartDate").className = "hideText";
    document.getElementById("liInvalidCrossYearPromotionStartDate").className = "hideText";
    document.getElementById("liSellOutStartDateValidation").className = "hideText";
    document.getElementById("liPromoEndSellOutStartValidation").className = "hideText";
    document.getElementById("liTokenCodeSelection").className = "hideText";
}
// CR 118
function HighlightHeaderErrorFields(id) {
    if (id != null) {
        $("#" + id.id).addClass('errorField');
    }
}
// CR 118 - Reverting the error fields
function RevertFields() {
    $(".elmToHighlight").removeClass('errorField');
}

function EnableCoPlanButton(xObj) {
    var ctrl = document.getElementById("btnCoPlan");
    if (ctrl != null) {
        if (xObj.checked) {
            document.getElementById("btnCoPlan").disabled = false;
        }
        else {
            document.getElementById("btnCoPlan").disabled = true;
        }
    }
}

function EnableBundleDropDownList() {
    var isChecked = $('#chkBundlePromotion').is(':checked');
    if (isChecked == true) {
        document.getElementById("ddlBundle").disabled = false;
    }
    else {
        document.getElementById("ddlBundle").disabled = true;
    }
}

//Validate Header Except dates and File Upload.
function PromotionHeaderValidation() {
    //Check the user clicked twice or not.
    if (!isNotDoubleClick())
        return false;
    ClearErrorMsg();
    RevertFields();
    var Validation = true;
    var vRxPromoName = new RegExp(document.getElementById("regPromoName").value, "ig");
    var vRXDurationValue = new RegExp("^[0-9]{1,3}$", "ig");

    var ddlplanningMde = document.getElementById("ddlPlanningMode");
    if (ddlplanningMde != null && ddlplanningMde.value == "-1") {
        HighlightHeaderErrorFields(document.getElementById("divPlanningMode"));  //CR 118  
        document.getElementById("liPlanningEntityMandatory").className = "showText";
        Validation = false;
    }
    else {

        var allowBackDatedPromotion = document.getElementById("hfAllowBackDatedPromotion").value;
        var allowCrossYearPromotion = document.getElementById("hfAllowCrossYearPromotion").value;
        var isChecked = $('#chkBundlePromotion').is(':checked');
        if (isChecked == "true") { allowCrossYearPromotion = "false"; }

        var currentDate = document.getElementById("hfCurrenDate").value.GetDatePart();
        if ((allowBackDatedPromotion == "false" || (allowCrossYearPromotion == "true" && $find(wdpPromStartDateCID).get_value().getFullYear() != $find(wdpPromEndDateCID).get_value().getFullYear())) && currentDate.setHours(0, 0, 0, 0) > $find(wdpPromStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0)) {

            HighlightHeaderErrorFields(document.getElementById("divStartDate"));  //CR 118  
            if (allowBackDatedPromotion == "false") {
                document.getElementById("liPromotionStartDate").className = "showText";
            }
            else {
                document.getElementById("liInvalidCrossYearPromotionStartDate").className = "showText";
            }
            Validation = false;
        }

        //Validate PromotionName Textbox
        if (document.getElementById("txtPromotionName").value.trim() == "") {
            HighlightHeaderErrorFields(document.getElementById("txtPromotionName"));  //CR 118  
            document.getElementById("liPromotionName").className = "showText";
            Validation = false;
        }
        else if (document.getElementById("txtPromotionName").value.trim() != "") {

            if ((vRxPromoName.test(document.getElementById("txtPromotionName").value.trim()))) {
                HighlightHeaderErrorFields(document.getElementById("txtPromotionName"));  //CR 118  
                document.getElementById("liPromotionNameReg").className = "showText";
                Validation = false;
            }
        }

        //Validate Duration Textbox
        if (!(vRXDurationValue.test(document.getElementById("txtDurationValue").value))) {
            HighlightHeaderErrorFields(document.getElementById("txtDurationValue")); // CR 118
            document.getElementById("liDuration").className = "showText";
            Validation = false;
        }

        //Added as part of PT-ULHD00010513433,The issue was with the promotion End date was planning lesser than promotion start date.
        if ($find(wdpPromEndDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) <
        $find(wdpPromStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0)) {
            document.getElementById("liPromotionEndDate").className = "showText";
            Validation = false;
        }


        //Validate whether user selected the Qualification.
        if (document.getElementById("ddlPromotionQualification")) {
            if (document.getElementById("ddlPromotionQualification").value == "-1") {
                HighlightHeaderErrorFields(document.getElementById("divPromoQualification"));  //CR 118  
                document.getElementById("liPromotionQualification").className = "showText";
                Validation = false;
            }

        }

        //Validate whether user selects a bundle
        if ($('#chkBundlePromotion').is(":visible") && $('#ddlBundle').is(":visible")) {
            if ($('#chkBundlePromotion').is(':checked') && document.getElementById("ddlBundle").value == "-1") {
                HighlightHeaderErrorFields(document.getElementById("divBundleName")); //CR 118  
                document.getElementById("liSelectBundle").className = "showText";
                Validation = false;
            }
        }

        //Check whether User had selected atleast one sales Org or not.
        if (document.getElementById("chkbSalesOrg") != null) {
            var checked = false;
            var chkBoxList = document.getElementById("chkbSalesOrg");
            var chkBoxCount = chkBoxList.getElementsByTagName("input");
            for (var i = 0; i < chkBoxCount.length; i++) {
                if (chkBoxCount[i].checked)
                    checked = true;
            }
            if (!checked) {
                HighlightHeaderErrorFields(document.getElementById("divSalesOrg")); //CR 118  
                document.getElementById("liSalesOrg").className = "showText";
                Validation = false;
            }
        }
        else {
            HighlightHeaderErrorFields(document.getElementById("divSalesOrg")); //CR 118
            document.getElementById("liSalesOrg").className = "showText";
            Validation = false;
        }

        //check whether user had selected marketing objective or not.
        if (document.getElementById("ddlMarketingObjectives").value == "-1") {
            HighlightHeaderErrorFields(document.getElementById("divMarketObj")); //CR 118
            document.getElementById("liMarketingObjectives").className = "showText";
            Validation = false;
        }

        //check whether user had selected Promotion objective or not.
        if (document.getElementById("ddlPromotionObjectives").value == "-1") {
            HighlightHeaderErrorFields(document.getElementById("divPromoObj")); //CR 118
            document.getElementById("liPromotionObjectives").className = "showText";
            Validation = false;
        }

        //check whether user had selected atleast one PromotionMechanic or not.
        if (document.getElementById("chkbPromotionMechanics") != null) {
            var checked = false;
            var chkBoxList = document.getElementById("chkbPromotionMechanics");
            var chkBoxCount = chkBoxList.getElementsByTagName("input");
            for (var i = 0; i < chkBoxCount.length; i++) {
                if (chkBoxCount[i].checked)
                    checked = true;
            }
            if (!checked) {
                HighlightHeaderErrorFields(document.getElementById("divMechCheckbox")); //CR 118
                document.getElementById("liPromotionMechanics").className = "showText";
                Validation = false;
            }
        }
        else {
            HighlightHeaderErrorFields(document.getElementById("divMechCheckbox")); //CR 118
            document.getElementById("liPromotionMechanics").className = "showText";
            Validation = false;
        }

        //Textbox length
        if ((document.getElementById('txtNotes').value.replace(/^\s*/, "").replace(/\s*$/, "")).length > 2000) {
            HighlightHeaderErrorFields(document.getElementById("txtNotes")); //CR 118
            document.getElementById("liTxtNoteExceed").className = "showText";
            Validation = false;

        }
        //Incase Note is mandatory
        if (document.getElementById("hfNoteMandatory").value == "1") {
            if (document.getElementById("txtNotes").value == "") {
                HighlightHeaderErrorFields(document.getElementById("txtNotes")); //CR 118
                document.getElementById("liNote").className = "showText";
                Validation = false;
            }
        }

        //Incase FileAttachment is mandatory
        if (document.getElementById("hfAttchemntMandatory").value == "1") {
            if (document.getElementById("dlFilesList") == null || document.getElementById("dlFilesList").children.length == 0) {
                HighlightHeaderErrorFields(document.getElementById("divCheckboxArea")); //CR 118
                document.getElementById("liAttachments").className = "showText";
                Validation = false;
            }
        }

        //Validate if TokenCode is linked for PayoutCode

        if (document.getElementById("ddlTknCdeType") != null) {

            var ddlTknCdeType = document.getElementById("ddlTknCdeType");
            if (ddlTknCdeType.value == "PayoutCode") {
                //                 if (!document.getElementById(".lblSelectedPayoutCode").val())
                //  var tknlbl = $('.lblSelectedPayoutCode').val();
                //var actualPrice = document.getElementById("<%=lblSelectedPayoutCode.ClientID %>").value;
                var tknlbl = $('.lblSelectedPayoutCode').val();
                var tknlbl = document.getElementById("lblSelectedPayoutCode").innerHTML;
                // var s = document.getElementsByTagName('lblSelectedPayoutCode')[0].firstChild.data
                if (!tknlbl) {
                    HighlightHeaderErrorFields(document.getElementById("divTokenCode"));
                    document.getElementById("liTokenCodeSelection").className = "showText";
                    Validation = false;
                }
            }
        }
    }


    if (Validation)
        return true;
    else {
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }

}

function CheckNumeric(e, obj, num) {
    if ((e.keyCode >= 48 && e.keyCode <= 57) || e.keyCode == 8)//Numbers or BackSpace
    {
        if (obj.value.length > num) {
            e.keyCode = 0;
        }
    }
    else {
        e.keyCode = 0;
    }
}

function alphanumeric_only(e) {
    var keycode;
    if (window.event) keycode = window.event.keyCode;
    else if (event) keycode = event.keyCode;
    else if (e) keycode = e.which;
    else return true; if ((keycode >= 47 && keycode <= 57) || (keycode >= 65 && keycode <= 90) || (keycode >= 97 && keycode <= 122) || (keycode == 32)) {
        return true;
    }
    else {
        return false;
    }
    return true;
}

$(document).ready(function () {

    $(".sample_attach, .menuArrow, #AdminSubMenu").mouseover(function () {
        $("li.active").css('background', '#e4dec6');
        $("#PromoMenu").css('background', '#fff');
    });
    $(".sample_attach, #AdminSubMenu").mouseout(function () {
        $("li.active").css('background', '#fff');
    });

    $(".sample_attach, .menuArrow, #PromoMenu, #ServicesSubMenu").mouseover(function () {
        $("li.active").css('background', '#e4dec6');
        $("li.active").css('background', '#e4dec6');
    });
    $(".sample_attach, #PromoMenu").mouseout(function () {
        $("li.active").css('background', '#fff');
    });

    $(".sample_attach, .menuArrow, #BudgetSubMenu").mouseover(function () {
        $("li.active").css('background', '#e4dec6');
        $("#PromoMenu").css('background', '#fff');
    });
    $(".sample_attach, #BudgetSubMenu").mouseout(function () {
        $("li.active").css('background', '#fff');
    });
    //function click on add a note
    $('#addanote').click(function () {
        $('#divsavedata').show();
        $('#addanote').hide();
        $('#nodata').hide();
    });
    //function click on edit note
    $('#editnote').click(function () {
        $('#editdata').show();
        $('#displaydisableddata').hide();
        $('#nodata').hide();
    });
    //function click on save button
    $('#savebtn').click(function () {
        $('#divsavedata').hide();
        $('#displaydisableddata').show();
        $('#editnote').show();
        $('#nodata').hide();
    });
    //function click on save again button
    $('#updatebtn').click(function () {
        $('#editdata').hide();
        $('#updatedata').show();
        $('#editnote').show();
        $('#nodata').hide();
    });
    //function click on remove button
    $('#removebtn').click(function () {
        $('#editdata').hide();
        $('#divsavedata').hide();
        $('#displaydisableddata').hide();
        $('#nodata').show();
        $('#updatedata').hide();
        $('#addanote').show();
        $('#editnote').hide();
    });
    //function click on updated remove button
    $('#removebtn1').click(function () {
        $('#editdata').hide();
        $('#editnote').hide();
        $('#divsavedata').hide();
        $('#displaydisableddata').hide();
        $('#nodata').show();
        $('#updatedata').hide();
        $('#addanote').show();
    });
    //function click on add files
    $('#addfiles').click(function () {
        $('#divuploadarea').show();
        $('#attachmentList').show();
        $('#addfiles').hide();
    });
    //function click on upload button
    $('#uploadbtn').click(function () {
        $('#divuploadarea').show();
        $('#attachmentList').show();
        $('#addfiles').hide();
    });
    //function click on remove attachment
    $('#removeattachment').click(function () {
        $('#divuploadarea').hide();
        $('#attachmentList').hide();
        $('#addfiles').show();
    });
    $('#btnsave').click(function () {
        $('#coplandiv').show();
        $('#formerror1').show();
        $('#formerror2').show();
        $('#formerror3').show();
    });
});

var btnDown = "btnadvanceDown";
var btnUp = "btnadvanceUp";
function showAnswer(id) {
    $("#answer" + id).show();
}

function hideAnswer(id) {
    $("#answer" + id).hide();
    $("#btnDown1").show();
}

function toggleExpansion(ctrlExpander, contentDivId) {

    if (ctrlExpander.className == btnDown) {
        $('#' + contentDivId).css('display', 'block');
        ctrlExpander.className = btnUp;
    }
    else {
        $('#' + contentDivId).css('display', 'none');
        ctrlExpander.className = btnDown;
    }
}
//here questionIDs is the question ids passed..
function showAll(questionIDs) {

    $("#expandButton").css('display', 'none');
    $("#collapseButton").css('display', 'block');

    var counter = questionIDs;
    var id = counter.split(',');
    var questions = '10';
    for (i = 0; i < questions; i++) {

        showAnswer(parseInt(id[i]));
    }
}

function hideAll(questionIDs) {
    $("#expandButton").css('display', 'block');
    $("#collapseButton").css('display', 'none');
    var counter = questionIDs;
    var id = counter.split(',');
    var questions = '10';
    for (i = 0; i < questions; i++) {
        hideAnswer(parseInt(id[i]));
    }
}


//Functions moved from aspx page

function ValidateFileUpload() {
    ClearErrorMsg();
    RevertFields();
    var flpPromoAttachments = document.getElementById(flpPromoAttachmentsCID);
    var FileUploadPath = flpPromoAttachments.value;
    var Validation = true;
    if (FileUploadPath == '') {
        Validation = false;
        HighlightHeaderErrorFields(document.getElementById("fileName"));  //CR 118     
        document.getElementById("liNoFileSelected").className = "showText";
    }
    else {
        var Extension = FileUploadPath.substring(FileUploadPath.lastIndexOf('.') + 1).toLowerCase();
        var fileName = FileUploadPath.substring(FileUploadPath.lastIndexOf('\\') + 1);
        if (ValidateFileExtension(Extension)) {
            Validation = true;
        }
        else {
            Validation = false;
            HighlightHeaderErrorFields(document.getElementById("fileName"));    //CR 118        
            document.getElementById("liFileExtension").className = "showText";
        }
    }
    if (Validation)
        return true;
    else {
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }
}

//Added as a part of PEN test defect fix (08-01-2014)
function ValidateFileExtension(fileExtension) {
    // Only the below file extensions are allowed for upload
    var whiteListExtensions = ["jpg", "jpeg", "gif", "png", "tif", "tiff", "txt", "doc", "docx", "pps", "pdf", "mp3", "wav", "avi", "mpg", "mpeg", "wmv", "iso",
                                 "flv", "mov", "dvr-ms", "vob", "xls", "xlsx", "csv", "ppt", "pptx", "zip", "rar", "msg", "htm", "html"];

    var isExtensionValid = false;

    for (var i = 0; i < whiteListExtensions.length; i++) {
        if (fileExtension.toUpperCase() == whiteListExtensions[i].toUpperCase()) {
            isExtensionValid = true;
            break;
        }
    }

    return isExtensionValid;
}

function set_str_date_fun(sender, args) {
    ClearErrorMsg();
    RevertFields();
    var Validation = true;
    if (args.get_value() == null)
        return;

    var currentDate = document.getElementById("hfCurrenDate").value.GetDatePart();
    var PlanningStartDate = document.getElementById("hfPlanningStartDate").value;
    var selectedStartDate = args.get_value().toString().GetDatePart();
    var minDate = document.getElementById("hfMinVal").value.GetDatePart();
    var maxDate = document.getElementById("hfMaxVal").value.GetDatePart();
    var allowBackDatedPromotion = document.getElementById("hfAllowBackDatedPromotion").value;
    var allowCrossYearPromotion = document.getElementById("hfAllowCrossYearPromotion").value
    var isChecked = $('#chkBundlePromotion').is(':checked');
    if (isChecked == "true") { allowCrossYearPromotion = "false"; }

    if (minDate.setHours(0, 0, 0, 0) > selectedStartDate.setHours(0, 0, 0, 0) || selectedStartDate.setHours(0, 0, 0, 0) > maxDate.setHours(0, 0, 0, 0)) {
        args.set_cancel(true);

        document.getElementById("liSelectedDateDoesNotExist").className = "showText";
        Validation = false;
    }
    else if ((allowBackDatedPromotion == "false" || (allowCrossYearPromotion == "true" && args.get_value().getFullYear() != $find(wdpPromEndDateCID).get_value().getFullYear())) && currentDate.setHours(0, 0, 0, 0) > selectedStartDate.setHours(0, 0, 0, 0)) {
        args.set_cancel(true);

        if (allowBackDatedPromotion == "false") {
            document.getElementById("liPromotionStartDate").className = "showText";
        }
        else {
            document.getElementById("liInvalidCrossYearPromotionStartDate").className = "showText";
        }
        Validation = false;
    }
    if (PlanningStartDate != null && PlanningStartDate != "" && (selectedStartDate.setHours(0, 0, 0, 0) < PlanningStartDate.GetDatePart().setHours(0, 0, 0, 0))) {
        args.set_cancel(true);

        document.getElementById("liPlanningEntityStartDate").className = "showText";
        Validation = false;
    }

    if (Validation)
        return true;
    else {
        HighlightHeaderErrorFields(document.getElementById("divStartDate")); //CR 118
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }
}

function set_selloutstr_date_fun(sender, args) {

    ClearErrorMsg();
    RevertFields();
    var Validation = true;
    var PreMinValue = document.getElementById("hfPreMinVal").value;

    if (args.get_value() == null)
        return;

    var PromotionSellOutEnddate = document.getElementById("hfPromotionSellOutEnddate").value;
    var currentDate = document.getElementById("hfCurrenDate").value.GetDatePart();

    // To check whether the selected date is available in the TimeHierarchy.
    var minDate = document.getElementById("hfMinVal").value.GetDatePart();
    var maxDate = document.getElementById("hfMaxVal").value.GetDatePart();
    var selectedDate = args.get_value().toString().GetDatePart();

    if (minDate.setHours(0, 0, 0, 0) > selectedDate.setHours(0, 0, 0, 0) || selectedDate.setHours(0, 0, 0, 0) > maxDate.setHours(0, 0, 0, 0)) {
        args.set_cancel(true);

        document.getElementById("liSelectedDateDoesNotExist").className = "showText";
        Validation = false;
    }
    else if ($find(wdpSellOutEndDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) < args.get_value().toString().GetDatePart()
             || (currentDate.setHours(0, 0, 0, 0) > selectedDate.setHours(0, 0, 0, 0))
            ) {
        args.set_cancel(true);

        document.getElementById("liPromotionSell_outStartDate").className = "showText";
        Validation = false;
    }

    if (Validation)
        return true;
    else {
        HighlightHeaderErrorFields(document.getElementById("divSellOutStartDate")); //CR 118
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }
}

function set_end_date_fun(sender, args) {
    ClearErrorMsg();
    RevertFields();
    var Validation = true;
    var currentDate = document.getElementById("hfCurrenDate").value;
    if (args.get_value() == null)
        return;
    var PromotionSellOutEnddate = document.getElementById("hfPromotionSellOutEnddate").value;
    var PlanningEndDate = document.getElementById("hfPlanningEndDate").value;

    // To check whether the selected date is available in the TimeHierarchy.
    var minDate = document.getElementById("hfMinVal").value.GetDatePart();
    var maxDate = document.getElementById("hfMaxVal").value.GetDatePart();
    var selectedDate = args.get_value().toString().GetDatePart();
    var allowBackDatedPromotion = document.getElementById("hfAllowBackDatedPromotion").value;
    var allowCrossYearPromotion = document.getElementById("hfAllowCrossYearPromotion").value;
    var isChecked = $('#chkBundlePromotion').is(':checked');
    if (isChecked == "true") { allowCrossYearPromotion = "false"; }

    if (minDate.setHours(0, 0, 0, 0) > selectedDate.setHours(0, 0, 0, 0) || selectedDate.setHours(0, 0, 0, 0) > maxDate.setHours(0, 0, 0, 0)) {
        args.set_cancel(true);
        document.getElementById("liSelectedDateDoesNotExist").className = "showText";
        Validation = false;
    }
    else if (($find(wdpPromStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart()) ||
                                   ($find(wdpPreStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart() ||
                                   (allowBackDatedPromotion == "false" && currentDate.GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart()))) {

        args.set_cancel(true);
        document.getElementById("liPromotionEndDate").className = "showText";
        Validation = false;
    }
    else if (allowCrossYearPromotion == "true" && $find(wdpPromStartDateCID).get_value().getFullYear() != args.get_value().getFullYear()) {
        if (currentDate.GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart() || currentDate.GetDatePart().setHours(0, 0, 0, 0) > $find(wdpPromStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0)) {
            args.set_cancel(true);
            document.getElementById("liInvalidCrossYearPromotionStartDate").className = "showText";
            Validation = false;
        }
    }
    if (PlanningEndDate != null && PlanningEndDate != "" && (selectedDate.setHours(0, 0, 0, 0) > PlanningEndDate.GetDatePart().setHours(0, 0, 0, 0))) {
        args.set_cancel(true);

        document.getElementById("liPlanningEntityEndDate").className = "showText";
        Validation = false;
    }

    if (Validation)
        return true;
    else {
        HighlightHeaderErrorFields(document.getElementById("divEndDate")); //CR 118
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }
}

function set_selloutend_date_fun(sender, args) {
    ClearErrorMsg();
    RevertFields();
    var Validation = true;

    if (args.get_value() == null)
        return;
    var PromotionSellOutEnddate = document.getElementById("hfPromotionSellOutEnddate").value;
    var PostMaxValue = document.getElementById("hfPostMaxVal").value;
    var currentDate = document.getElementById("hfCurrenDate").value.GetDatePart();

    // To check whether the selected date is available in the TimeHierarchy.
    var minDate = document.getElementById("hfMinVal").value.GetDatePart();
    var maxDate = document.getElementById("hfMaxVal").value.GetDatePart();
    var selectedDate = args.get_value().toString().GetDatePart();

    if (minDate.setHours(0, 0, 0, 0) > selectedDate.setHours(0, 0, 0, 0) || selectedDate.setHours(0, 0, 0, 0) > maxDate.setHours(0, 0, 0, 0)) {
        args.set_cancel(true);

        document.getElementById("liSelectedDateDoesNotExist").className = "showText";
        Validation = false;
    }
    else if ($find(wdpSellOutStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart()
            || (currentDate.setHours(0, 0, 0, 0) > selectedDate.setHours(0, 0, 0, 0))
            ) {

        args.set_cancel(true);

        document.getElementById("liPromotionSell_outEndDate").className = "showText";
        Validation = false;
    }

    if (PostMaxValue.GetDatePart() < args.get_value().toString().GetDatePart()) {
        args.set_cancel(true);

        document.getElementById("liPostMaxDate").className = "showText";
        Validation = false;
    }

    if (Validation)
        return true;
    else {
        HighlightHeaderErrorFields(document.getElementById("divSellOutEndDate")); //CR 118
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }
}

function set_prestart_date_fun(sender, args) {
    ClearErrorMsg();
    RevertFields();
    var Validation = true;
    var PreMinValue = document.getElementById("hfPreMinVal").value;
    if (args.get_value() == null)
        return;
    // To check whether the selected date is available in the TimeHierarchy.

    var minDate = document.getElementById("hfMinVal").value.GetDatePart();
    var maxDate = document.getElementById("hfMaxVal").value.GetDatePart();
    var selectedDate = args.get_value().toString().GetDatePart();
    var PlanningPreStartDate = document.getElementById("hfPlanningPreStartDate").value;

    if (minDate.setHours(0, 0, 0, 0) > selectedDate.setHours(0, 0, 0, 0) || selectedDate.setHours(0, 0, 0, 0) > maxDate.setHours(0, 0, 0, 0)) {
        args.set_cancel(true);

        document.getElementById("liSelectedDateDoesNotExist").className = "showText";
        Validation = false;
    }
    else if (($find(wdpPromStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) < args.get_value().toString().GetDatePart()) ||
                                ($find(wdpPromEndDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) < args.get_value().toString().GetDatePart()) ||
                                ($find(wdpPostEndDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) < args.get_value().toString().GetDatePart())) {
        args.set_cancel(true);

        document.getElementById("liPromotionPre_StartDate").className = "showText";
        Validation = false;
    }
    else if (PreMinValue.GetDatePart() > args.get_value().toString().GetDatePart()) {
        args.set_cancel(true);

        document.getElementById("liPreMinDate").className = "showText";
        Validation = false;
    }
    if (PlanningPreStartDate != null && PlanningPreStartDate != "" && (selectedDate.setHours(0, 0, 0, 0) < PlanningPreStartDate.GetDatePart().setHours(0, 0, 0, 0))) {
        args.set_cancel(true);

        document.getElementById("liPlanningEntityPreStartDate").className = "showText";
        Validation = false;
    }

    if (Validation)
        return true;
    else {
        HighlightHeaderErrorFields(document.getElementById("divPreStartDate")); //CR 118
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }
}

//Convert string to date Datatype
String.prototype.GetDatePart = function () {
    return new Date(this);
}
function set_postend_date_fun(sender, args) {
    ClearErrorMsg();
    RevertFields();
    var Validation = true;
    var PostMaxValue = document.getElementById("hfPostMaxVal").value;
    if (args.get_value() == null)
        return;
    // To check whether the selected date is available in the TimeHierarchy.
    var minDate = document.getElementById("hfMinVal").value.GetDatePart();
    var maxDate = document.getElementById("hfMaxVal").value.GetDatePart();
    var selectedDate = args.get_value().toString().GetDatePart();
    var PlanningPostEndDate = document.getElementById("hfPlanningPostEndDate").value;

    if (minDate.setHours(0, 0, 0, 0) > selectedDate.setHours(0, 0, 0, 0) || selectedDate.setHours(0, 0, 0, 0) > maxDate.setHours(0, 0, 0, 0)) {
        args.set_cancel(true);

        document.getElementById("liSelectedDateDoesNotExist").className = "showText";
        Validation = false;
    }
    else if (($find(wdpPromStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart()) ||
                                ($find(wdpPromEndDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart()) ||
                                ($find(wdpPreStartDateCID).get_value().toString().GetDatePart().setHours(0, 0, 0, 0) > args.get_value().toString().GetDatePart())) {
        args.set_cancel(true);

        document.getElementById("liPromotionPost_EndDate").className = "showText";



        Validation = false;
    }
    else if (PostMaxValue.GetDatePart() < args.get_value().toString().GetDatePart()) {
        args.set_cancel(true);

        document.getElementById("liPostMaxDate").className = "showText";
        Validation = false;
    }
    if (PlanningPostEndDate != null && PlanningPostEndDate != "" && (selectedDate.setHours(0, 0, 0, 0) > PlanningPostEndDate.GetDatePart().setHours(0, 0, 0, 0))) {
        args.set_cancel(true);

        document.getElementById("liPlanningEntityPostEndDate").className = "showText";
        Validation = false;
    }

    if (Validation)
        return true;
    else {
        HighlightHeaderErrorFields(document.getElementById("divPostEndDate")); //CR 118
        document.getElementById("plErrorMessages").className = "showText";
        window.scrollTo(0, 0);
        return false;
    }
}

//For File Download
function ShowFile(fileName, recStatus) {

    var iframe = document.createElement("iframe");
    iframe.setAttribute('id', 'docFrame');
    iframe.style.width = "0px";
    iframe.style.height = "0px";
    iframe.style.border = "0px";
    params = "&filename=" + encodeURIComponent(fileName.replace("\\'", "'")) + "&RecStatus=" + recStatus;
    iframe.src = "../Handlers/PromotionFileDownloadHandler.ashx?" + params;
    document.body.appendChild(iframe);
    iframe.style.display = "none";

    return false;
}
function DownloadPromotionAttachment(obj) {
    filename = obj.getAttribute('FileName');
    filename = filename.replace("'", "\\'");
    recStatus = obj.getAttribute('RecStatus');
    //If old file then checking file is there in the server or not. for newly uploaded no need to check it.
    if (recStatus == 0) {
        var url = "../Webservices/PromotionFileDownloadWebservice.asmx/IsFileExists?&fileName='" + encodeURIComponent(filename) + "'";
        _ajaxGet(filename, url, recStatus);
    }
    else {
        ShowFile(filename, recStatus);
    }
    return false;
}
function ShowError() {
    ShowAlert('FilenotfoundpopupAlert');
}
function _ajaxGet(filename, url, recStatus) {
    $.ajax({
        type: "GET",
        url: url,
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.d == "True")
                ShowFile(filename, recStatus);
            else {
                ShowError();
            }
        },
        error: function (msg) { alert('failed'); },
        async: true,
        processData: false
    })
}
function toggleSelection(source) {

    var isChecked = source.checked;
    $("#GridViewTokenCodeDetails input[id*='tknCdeRadioButton']").each(function (index) {
        $(this).attr('checked', false);
    });
    source.checked = isChecked;
}


