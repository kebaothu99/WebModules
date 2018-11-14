'use strict';
$(document).ready(function () {
    $(".select2-placeholder").select2({
        placeholder: "Please select",
        allowClear: true
    });


    $('.autonumber').autoNumeric('init');


    tinymce.init({
        selector: 'textarea',
        height: 200,
        theme: 'modern',
        plugins: [
            'advlist autolink lists link image charmap print preview hr anchor pagebreak',
            'searchreplace wordcount visualblocks visualchars code fullscreen',
            'insertdatetime media nonbreaking save table contextmenu directionality',
            'emoticons template paste textcolor colorpicker textpattern imagetools codesample toc'
        ],
        toolbar1: 'undo redo | insert | styleselect | bold italic | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | link image',
        toolbar2: 'print preview media | forecolor backcolor emoticons | codesample',
        image_advtab: true
    });


    $(".form-material input.form-control").each(function (index) {
        var $this = $(this);
        if ($this.val()) {
            $this.addClass("fill");
        }
    });
});