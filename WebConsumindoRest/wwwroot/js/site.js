$(document).ready(function () {
    $('#dtTodos').DataTable();
    $('.dataTables_length').addClass('bs-select');
});

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});