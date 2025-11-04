

// Add Item page
$(document).ready(function () {

    $('.btn.btn-outline-secondary').on('click', function () {

        // Toggle selected class
        $(this).toggleClass('selected');

        // Get all selected sizes
        let selectedSizes = [];
        $('.btn.btn-outline-secondary.selected').each(function () {
            selectedSizes.push($(this).text().trim());
        });

        // Update hidden input
        $('#selectedSizes').val(selectedSizes.join(','));
    });

});