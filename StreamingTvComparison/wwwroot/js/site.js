
function setupChannelTable() {
    $('#tblChannels').bootstrapTable({
        pagination: true,
        pageList: [25, 50, 100, 'All'],
        search: true,
        sortable: true,
        showColumns: true
    });
}
