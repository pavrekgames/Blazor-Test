window.apiFunctions = {
    registerUser: function (url, data) {
        return fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data)
        })
            .then(response => {
                return response.json();
            })
            .catch(error => {
                return Promise.reject(error.message);
            });
    },
    changeColor: function () {
        const button = document.querySelector('div');
        const labels = document.querySelectorAll('label');
        button.style.backgroundColor = 'red';

        for (i = 0; i < labels.length; i++) {
            labels[i].style.color = "green";
        }
    },
    hideLabels: function () {
        $("label").hide();
    }
};;