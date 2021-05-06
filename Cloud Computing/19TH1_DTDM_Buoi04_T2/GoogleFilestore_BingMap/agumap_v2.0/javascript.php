<!-- Option 1: jQuery and Bootstrap Bundle (includes Popper) -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js"></script>

<!-- The core Firebase JS SDK is always required and must be listed first -->
<script src="https://www.gstatic.com/firebasejs/8.3.1/firebase-app.js"></script>

<!-- Firestore -->
<script src="https://www.gstatic.com/firebasejs/8.3.1/firebase-firestore.js"></script>

<!-- TODO: Add SDKs for Firebase products that you want to use https://firebase.google.com/docs/web/setup#available-libraries -->
<script src="https://www.gstatic.com/firebasejs/8.3.1/firebase-analytics.js"></script>

<script>
	// Your web app's Firebase configuration
	// For Firebase JS SDK v7.20.0 and later, measurementId is optional
	var firebaseConfig = {
		  apiKey: "AIzaSyCIHWHu5W7IJKAu7JcwEUwLiTYyTz96pHs",
		  authDomain: "agumap-nguyenhoangdanh.firebaseapp.com",
		  projectId: "agumap-nguyenhoangdanh",
		  storageBucket: "agumap-nguyenhoangdanh.appspot.com",
		  messagingSenderId: "293676283447",
		  appId: "1:293676283447:web:72f0b49ff32f142039b1b2",
		  measurementId: "G-JNGMYHY0DR"
	};
	// Initialize Firebase
	firebase.initializeApp(firebaseConfig);
	firebase.analytics();
	var db = firebase.firestore();
</script>