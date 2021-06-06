const APP_ID='bed3d99a451f7b2e24f1f10d53c84586';

const DEAFAULT_VALUE='--'
const searchInput = document.querySelector('#search-input');
const cityName=document.querySelector('.city-name');
const weatherState=document.querySelector('.weather-state');
const weatherIcon=document.querySelector('.weather-icon');
const temprature=document.querySelector('.temperature');
const sunrise=document.querySelector('.sunrise');
const sunset=document.querySelector('.sunset');
const tri=document.querySelector('.tri');
const humidity=document.querySelector('.humidity');
const windSpeed=document.querySelector('.wind-speed');
const seaLevel = document.querySelector('.sea-level');
const pressure = document.querySelector('.pressure');
const temptb = document.querySelector('.temptb');


searchInput.addEventListener('change',(e)=>{
	fetch(`https://api.openweathermap.org/data/2.5/weather?q=${e.target.value}&appid=${APP_ID}&units=metric&lang=vi`)
		.then(async res=>{
			const data=await res.json();
			console.log('[Search Input]', data);
			
			sunrise.innerHTML=moment.unix(data.sys.sunrise).format('H:mm') || DEAFAULT_VALUE;
			sunset.innerHTML=moment.unix(data.sys.sunset).format('H:mm') || DEAFAULT_VALUE;
			humidity.innerHTML=data.main.humidity || DEAFAULT_VALUE;
			windSpeed.innerHTML=(data.wind.speed * 3.6).toFixed(2) || DEAFAULT_VALUE;
			seaLevel.innerHTML=data.main.sea_level;
			pressure.innerHTML=data.main.pressure;
			temptb.innerHTML=data.main.temp;
		});
});