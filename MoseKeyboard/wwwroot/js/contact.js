var mailField = document.getElementById("mailField")
var nameField = document.getElementById("nameField")
var messageField = document.getElementById("messageField")
var emailRegex = /^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$/;
var instBtn = document.getElementById("instBtn")
var linkBtn = document.getElementById("linkBtn")
var tgBtn = document.getElementById("tgBtn")

function sendMail() {
    if (emailRegex.test(mailField.value)) {
        var params = {
            name: nameField.value,
            email: mailField.value,
            message: messageField.value,
        };
        const serviceId = "service_yheso6f"
        const templateId = "template_3ko8luv"

        emailjs.send(serviceId, templateId, params)
            .then((res) => {
                nameField.value = "";
                mailField.value = "";
                messageField.value = "";
                console.log(res);
                alert("Your message sent succesfully!");
            })
            .catch((err) => console.log(err))
    }
    else
        alert("Please, enter valid mail!")
}

function linksClick(button) {
    switch (button) {
        case instBtn:
            window.open("https://www.instagram.com/moseeeu/")
            break;
        case linkBtn:
            window.open("https://www.linkedin.com/in/alexandr-kalyan-25809627b/")
            break;
        case tgBtn:
            window.open("https://t.me/moseeeu")
            break;
    }
}