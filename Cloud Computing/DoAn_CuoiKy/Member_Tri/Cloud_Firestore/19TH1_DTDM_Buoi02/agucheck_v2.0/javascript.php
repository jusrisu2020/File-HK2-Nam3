<!-- Option 1: jQuery and Bootstrap Bundle (includes Popper) -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js"></script>

<!-- The core Firebase JS SDK is always required and must be listed first -->
<script src="https://www.gstatic.com/firebasejs/8.2.9/firebase-app.js"></script>

<!-- Firestore -->
<script src="https://www.gstatic.com/firebasejs/8.2.9/firebase-firestore.js"></script>

<!-- TODO: Add SDKs for Firebase products that you want to use https://firebase.google.com/docs/web/setup#available-libraries -->
<script src="https://www.gstatic.com/firebasejs/8.2.9/firebase-analytics.js"></script>

<script>
	// Your web app's Firebase configuration
	// For Firebase JS SDK v7.20.0 and later, measurementId is optional
	var firebaseConfig = {
			apiKey: "AIzaSyDj6_lqpvPBfZlcJfO8n5XKXJtCoOqmf6A",
		  authDomain: "agucheck-ptngoc.firebaseapp.com",
		  projectId: "agucheck-ptngoc",
		  storageBucket: "agucheck-ptngoc.appspot.com",
		  messagingSenderId: "1065659182003",
		  appId: "1:1065659182003:web:a4d0f8f9d860665f5f39c6",
		  measurementId: "G-K54NH4JZG1"
	};
	// Initialize Firebase
	firebase.initializeApp(firebaseConfig);
	firebase.analytics();
	var db = firebase.firestore();
</script>