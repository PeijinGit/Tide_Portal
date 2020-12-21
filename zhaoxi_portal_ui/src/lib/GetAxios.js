import axios from "axios"

var getAxiosJsonResAsync = function(jsonName, func){
    if (jsonName == null) return;
    axios.get(`/jsons/${jsonName}.json`).then(function(res) {
      func(res.data);
    });
}

export{
    getAxiosJsonResAsync,
}