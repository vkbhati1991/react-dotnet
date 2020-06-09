
function setSessionStorage(data) {
    sessionStorage.setItem("mnTokenValid", data);
}

function getSessionStorage() {
    sessionStorage.getItem("mnTokenValid");
}

function removeSessionStorage() {
    sessionStorage.removeItem("mnTokenValid");
}

function isLogging() {
    if ("mnTokenValid" in sessionStorage) {
        return true;
    }
    return false;
}

export { setSessionStorage, getSessionStorage, removeSessionStorage, isLogging };