
function toggleDeviceSendState(id) {
    const element = document.getElementById("btn-send-" + id)

    if (element.innerText === "START") {
        element.innerText = "STOP"
        return
    }

    if (element.innerText === "STOP") {
        element.innerText = "START"
        return
    }
}