function GetFile()
{
    var xhr = new XMLHttpRequest();
    xhr.open('GET', '/Saved/DownloadFile', true);
    xhr.send();
}