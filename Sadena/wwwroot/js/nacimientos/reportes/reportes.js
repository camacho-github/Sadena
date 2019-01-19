/* Script for: Reportes */

$(function () {

    /* Unregistered table */
    $('#unregisteredTable').DataTable({
        'scrollX': true,
        'searching': true,
        'ordering': true,
        'paging': true,
        'lengthChange': false,
        'info': false,
        'autoWidth': true
    });

    /* Registered table */
    $('#registeredTable').DataTable({
        'scrollX': true,
        'searching': true,
        'ordering': true,
        'paging': true,
        'lengthChange': false,
        'info': false,
        'autoWidth': true
    });

    /* Subregistered table */
    $('#subregisteredTable').DataTable({
        'scrollX': true,
        'searching': true,
        'ordering': true,
        'paging': true,
        'lengthChange': false,
        'info': false,
        'autoWidth': true
    });


    // Initialize components
    $('.treeview').blur(function () {
        $(this).removeClass('active');
    });

    $('.treeview').click(function () {
        $(this).addClass('active');
    });

    $('#searchBtn').click(function () {
        $('#searchingResult').show();
    });

    $('#loadBtn').click(function () {
        $('#infoModal').show();
    });

});