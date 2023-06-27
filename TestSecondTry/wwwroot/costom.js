
function line2()
{
    const list = document.getElementsByClassName(".custom_line");
    const check = document.getElementsByClassName(".chack_original");

    check.addEventListener('checked')
    {
        list.classList.add('line2');
    }

}