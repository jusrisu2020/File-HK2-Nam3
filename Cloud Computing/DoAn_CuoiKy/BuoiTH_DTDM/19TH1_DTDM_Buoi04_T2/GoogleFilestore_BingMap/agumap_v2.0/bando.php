<!DOCTYPE html>
<html lang="en">
	<?php include "header.php"; ?>
	
	<body>
		<div class="container">
			<?php include "navbar.php"; ?>
			
			<div class="card mt-3">
				<h5 class="card-header">Bản đồ</h5>
				<div  id="map"></div>
			</div>
			
			<?php include "footer.php"; ?>
		</div>
		
		<?php include "javascript.php"; ?>
			<script async
			src="https://maps.googleapis.com/maps/api/js?key=AIzaSyB3KjEa7xtALLCMJHqufeQP6AGQSwHDBTs&callback=initMap">
			</script>
		</head>
		<body>
		
		<script>
		
		
			let map;

			function initMap() {
			  map = new google.maps.Map(document.getElementById("map"), {
				center: { lat: 10.378417296945036 ,lng:  105.43954201435334},
				zoom: 15,
				
			  });
			  
			  var marker;
			  var infowindow = new google.maps.InfoWindow();
			  
			  db.collection("diadiem").get().then((querySnapshot) => {
					querySnapshot.forEach((doc) => {
						var marker_icon = '';
						
						if(doc.data().LoaiDiaDiem == 4 )
							marker_icon ='images/hotel.png';
						else if(doc.data().LoaiDiaDiem == 5 )
							marker_icon ='images/hospital.png';
							else if(doc.data().LoaiDiaDiem == 7 )
							marker_icon ='images/restaurant.png';
						else
							marker_icon ='images/location.png';
						
						marker = new google.maps.Marker({
							position: new google.maps.LatLng(doc.data().ToaDo.latitude, doc.data().ToaDo.longitude),
							map: map,
							icon : marker_icon,
							animation: google.maps.Animation.DROP
						});
								var info = '<div><h6 class ="text-primary">'+doc.data().TenDiaDiem+'</h6><p> Dia chi: '+doc.data().DiaChi+'</p></div>'
							google.maps.event.addListener(marker, 'click', (function(marker) {
							return function() {
								if (marker.getAnimation() !== null) {
										marker.setAnimation(null);
									  } else {
										marker.setAnimation(google.maps.Animation.BOUNCE);
									  }
								
								infowindow.setContent(info);
								infowindow.open(map, marker);
							}
						})(marker));
					});
				});
				
				const styles = {
				  default: [],
				  hide: [
					{
					  featureType: "poi",
					  stylers: [{ visibility: "off" }],
					},
					{
					  featureType: "transit",
					  elementType: "labels.icon",
					  stylers: [{ visibility: "off" }],
					},
					{
					  featureType: "road.local",
					  elementType: "labels.text.fill",
					  stylers: [{ color: "#0ffff0" }],
					},
				  ],
				};
				map.setOptions({ styles: styles["hide"] });
			}
		</script>
	</body>
</html>