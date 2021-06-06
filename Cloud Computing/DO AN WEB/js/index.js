const APP_ID='bed3d99a451f7b2e24f1f10d53c84586';

const Map_ID='AIzaSyDKbUG34YYWxj9VnkrR0LOEiVwhPPt0dHU';
const DEAFAULT_VALUE='--'
const searchInput = document.querySelector('#search-input');
const cityName=document.querySelector('.city-name');
const weatherState=document.querySelector('.weather-state');
const weatherIcon=document.querySelector('.weather-icon');
const temprature=document.querySelector('.temperature');

const sunrise=document.querySelector('.sunrise');
const sunset=document.querySelector('.sunset');
const humidity=document.querySelector('.humidity');
const windSpeed=document.querySelector('.wind-speed');


searchInput.addEventListener('change',(e)=>{
	fetch(`https://api.openweathermap.org/data/2.5/weather?q=${e.target.value}&appid=${APP_ID}&units=metric&lang=vi`)
		.then(async res=>{
			const data=await res.json();
			console.log('[Search Input]', data);
			cityName.innerHTML=data.name || DEAFAULT_VALUE;
			weatherState.innerHTML=data.weather[0].description || DEAFAULT_VALUE;
			weatherIcon.setAttribute('src',`http://openweathermap.org/img/wn/${data.weather[0].icon}@2x.png`);
			temprature.innerHTML=Math.round(data.main.temp) || DEAFAULT_VALUE;

			sunrise.innerHTML=moment.unix(data.sys.sunrise).format('H:mm') || DEAFAULT_VALUE;
			sunset.innerHTML=moment.unix(data.sys.sunset).format('H:mm') || DEAFAULT_VALUE;
			humidity.innerHTML=data.main.humidity || DEAFAULT_VALUE;
			windSpeed.innerHTML=(data.wind.speed * 3.6).toFixed(2) || DEAFAULT_VALUE;

		});
});

searchInput.addEventListener('change',(e)=>{
	
	fetch(`https://maps.googleapis.com/maps/api/geocode/json?address=${e.target.value}&key=${Map_ID}&lang=vi`)
	.then(async res=>{
		const set=await res.json();
		console.log('[search map]',set);
		let MarketArray = [
            {position: {lat: set.results[0].geometry.location.lat, lng: set.results[0].geometry.location.lng},
         
          content:`Latitude: ${set.results[0].geometry.location.lat}`+`<br/>Longitude: ${set.results[0].geometry.location.lng} `+`<br/>${set.results[0].formatted_address}`
			}
		]
		
		function addmarket(vt){
			
			var marker=new google.maps.Marker({
			  position:vt.position,
			  map:map,
				draggable:true,
			  animation:google.maps.Animation.DROP,
			  icon:vt.imageIcon
			  
			});
				map.setZoom(15);
				map.setCenter(marker.getPosition());
			if(vt.imageIcon)
			{
			  marker.setIcon(vt.imageIcon)
			}
			if(vt.content)
			{
			  const infoindow=new google.maps.InfoWindow({
			  content:vt.content
			 });
				marker.addListener('click',function(){					
				infoindow.open(map,marker);
			  });
		
			}  
				google.maps.event.addListener(marker,'click',function() {
				map.setZoom(15);
				map.setCenter(marker.getPosition());
				
		});
		  }
		  google.maps.event.addListener(map,"click",(event)=>{
			addmarket({
			  position:event.latLng,
			  
			});
		 })
			// var marker=new google.maps.Marker({
			// 	position:{lat: 21.0277644, lng: 105.8341598}
			// 	});
			
			// marker.setMap(map);
		//   Array
				for(let i = 0;i<MarketArray.length;i++)
				{
					addmarket(MarketArray[i]);
				}
				// add market
				
	});
});

function initMap() {
    var options = 
     {
      center: {lat: 10.378428946608638, lng: 105.43958084844778 },
      zoom: 7,
      scrollwheel:true
    }


   map = new google.maps.Map(document.getElementById("map"),options)

  
   
//    Market

}
