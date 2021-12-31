export function toggleRow(id) {
    var x = document.getElementById(id);
    if (x.style.display === "none") {
        x.removeAttribute("style");
    } else {
        x.style.display = "none";
    }
}