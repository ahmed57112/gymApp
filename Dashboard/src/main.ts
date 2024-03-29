import './assets/main.css'


import PrimeVue from 'primevue/config';
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
     
import axios from 'axios';

import 'primevue/resources/themes/saga-blue/theme.css'
import 'primevue/resources/primevue.min.css'
import 'primeicons/primeicons.css'

const app = createApp(App)

app.use(router)
app.use(PrimeVue);




app.mount('#app')
