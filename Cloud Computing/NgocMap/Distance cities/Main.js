//javascript.js
//set map options
var locations = [
      ['<h5>Bà Rịa - Vũng Tàu</h5><img src= "img/vungtau.png"><a href = "https://www.google.com/maps/@10.0750213,106.1419157,14.5z?hl=vi">Đi đến google map</a>',10.4120029121221,107.149078022389,1],
      ['<h5>Long Xuyên-AG</h5><img src= "150px-Emblem_of_Angiang_Province.png">',10.3792226495833,105.419372639898,1],
      ['<h5>Bắc Giang</h5><img src= "img/bacgiang.png">',21.2822346050205,106.197344097589,1],
      ['<h5>Bắc Kạn </h5><img src= "img/backan.png">',22.1905785875305,105.738332614536,1],
      ['<h5>Bạc Liêu</h5><img src= "img/baclieu.png">',9.29863508902594,105.695618896148,1],

      ['<h5>Bắc Ninh</h5><img src= "img/bacninh.png">',21.1782714417975,106.065173573627,1],
      ['<h5>Bến Tre</h5><img src= "img/bentre.png">',10.2241631460983,106.371825859218,1],
      ['<h5>Bình Định</h5><img src= "img/binhdinh.png">',13.7882498666392,109.213960726493,1],
      ['<h5>Bình Dương</h5><img src= "img/vungtau.png">',10.9915657184512,106.577967022023,1],
      ['<h5>Bình Phước</h5><img src= "img/vungtau.png">',11.5345712222625,106.887179592475,1],
      

      ['<h5>Bình Thuận</h5><img src= "img/vungtau.png">',10.9762064670238,108.272137105394,1],
      ['<h5>Cà Mau</h5><img src= "img/vungtau.png">',9.1523113383221,105.1954244769,1],
      ['<h5>Cần Thơ</h5><img src= "img/vungtau.png">',10.0341654805512,105.778697092365,1],
      ['<h5>Cao Bằng</h5><img src= "img/vungtau.png">',22.6908696660218,106.344455601161,1],
      ['<h5>Đà Nẵng</h5><img src= "img/vungtau.png">',16.0473605118113,108.219441561231,1],

      ['<h5>Đắk Lắk><img src= "img/vungtau.png">',12.6673559566558,108.036973010182,1],
      ['<h5>Đắk Nông</h5><img src= "img/vungtau.png">',12.00527478423,107.689230786272,1],
      ['<h5>Đồng Nai</h5><img src= "img/vungtau.png">',10.9634026883527,106.831947599015,1],
      ['<h5>Đồng Tháp</h5><img src= "img/vungtau.png">',10.4563237619646,105.635132095968,1],
      ['<h5>Gia Lai</h5><img src= "img/vungtau.png">',14.0148989192644,108.074991062063,1],

      ['<h5>Hà Giang><img src= "img/vungtau.png">',22.8135831090413,105.009646521868,1],
      ['<h5>Hà Nam</h5><img src= "img/vungtau.png">',20.5311608944001,105.916090790684,1],
      ['<h5>Hà Nội</h5><img src= "img/vungtau.png">',21.0293777428774,105.85219524413,1],
      ['<h5>Hà Tĩnh</h5><img src= "img/vungtau.png">',18.3566850628692,105.883461840783,1],
      ['<h5>Hải Dương</h5><img src= "img/vungtau.png">',20.9376220804355,106.314299697741,1],
    ];
/*const NEW_ZEALAND_BOUNDS = {
    north: 23.402056839646,
    south:8.573202858719934,
    west: 107.33236095599285,
    east: 108.94019085836108
  };  */
var mapOptions = {
    center: new google.maps.LatLng(10.371824649098098, 105.43240326983677),
    zoom: 7,
    scrollwheel:true,
    mapTypeId: google.maps.MapTypeId.ROADMAP,
    /*restriction: {
            latLngBounds: NEW_ZEALAND_BOUNDS,
            strictBounds: false,
          },*/

};
//create map
var map = new google.maps.Map(document.getElementById('googleMap'), mapOptions);
//thêm
var infowindow = new google.maps.InfoWindow({
    maxWidth: 200,
});
var marker, i;
for(i = 0; i < locations.length; i++){
    marker = new google.maps.Marker({
          position: new google.maps.LatLng(locations[i][1], locations[i][2]),// vị trí mà marker hiện thị
          map: map, // bản đồ mà marker gắn lên
          animation:google.maps.Animation.DROP,
          icon:{
            url:'a.png',
            //anchor: {x:50,y:50} mình xác định vị trí cho Marker
          }
    });
    google.maps.event.addListener(marker, 'click', (function(marker, i) {
        return function() {
          infowindow.setContent(locations[i][0]);
          infowindow.open(map, marker);
          map.setZoom(8);
          map.setCenter(locations[i][1],locations[i][2]);
          //streetViewControlOptions: google.maps.ControlPosition.RIGHT_CENTER
      }
    })(marker, i));
    
    
}
//create a DirectionsService object to use the route method and get a result for our request
var directionsService = new google.maps.DirectionsService();

//create a DirectionsRenderer object which we will use to display the route
var directionsDisplay = new google.maps.DirectionsRenderer();

//bind the DirectionsRenderer to the map
directionsDisplay.setMap(map);

var myLatLng = { lat: 10.371824649098098, lng: 105.43240326983677 };
//define calcRoute function
function calcRoute() {
    //create request
    var request = {
        origin: document.getElementById("from").value,
        destination: document.getElementById("to").value,
        travelMode: google.maps.TravelMode.DRIVING, //WALKING, BYCYCLING, TRANSIT
        unitSystem: google.maps.UnitSystem.METRIC
    }

    //pass the request to the route method
    directionsService.route(request, function (result, status) {
        if (status == google.maps.DirectionsStatus.OK) {

            //Get distance and time
            const output = document.querySelector('#output');
            output.innerHTML = "<div class='alert-info'>From: " + document.getElementById("from").value + ".<br />To: " + document.getElementById("to").value + ".<br /> Driving distance <i class='fas fa-road'></i> : " + result.routes[0].legs[0].distance.text + ".<br />Duration <i class='fas fa-hourglass-start'></i> : " + result.routes[0].legs[0].duration.text + ".</div>";

            //display route
            directionsDisplay.setDirections(result);
        } else {
            //delete route from map
            directionsDisplay.setDirections({router: []});
            //center map in London
            map.setCenter(myLatLng);

            //show error message
            output.innerHTML = "<div class='alert-danger'><i class='fas fa-exclamation-triangle'></i> Could not retrieve driving distance.</div>";
        }
    });

}



//create autocomplete objects for all inputs
	var options = {
	    types: ['(cities)']
	}

var input1 = document.getElementById("from");
var autocomplete1 = new google.maps.places.Autocomplete(input1, options);

var input2 = document.getElementById("to");
var autocomplete2 = new google.maps.places.Autocomplete(input2, options);



var markerSearch = new google.maps.Marker({ 
  map: map,
  animation:google.maps.Animation.BOUNCE,
  icon:{
    url:'a.png',
    //anchor: {x:50,y:50} mình xác định vị trí cho Marker
  }

})

var autoSearch = new google.maps.places.Autocomplete(document.getElementById("pac-input"))
autoSearch.addListener('place_changed',function(){
  place = autoSearch.getPlace();

  map.setCenter(place.geometry.location);
  markerSearch.setPosition(place.geometry.location);
  console.log(autoSearch.getPlace());

})
