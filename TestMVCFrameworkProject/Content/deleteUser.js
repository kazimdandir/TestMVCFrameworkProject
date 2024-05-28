function deleteUser(userId) {
    $.ajax({
        url: '/User/DeleteUser',
        type: 'POST',
        data: { id: userId },
        success: function (response) {
            if (response.success) {
                location.reload(); // Sayfayı yenilemek
            } else {
                alert(response.message);
            }
        },
        error: function () {
            alert('Error occurred while deleting the user.');
        }
    });
}