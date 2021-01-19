import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from './store'

Vue.config.productionTip = false

let baseUrl = ''
if (process.env.NODE_ENV === 'production') {
   baseUrl = 'https://tiasdev-backend.herokuapp.com/rest/api/latest';
} else {
   baseUrl = 'https://localhost:5001/rest/api/latest';
}

export const apiHost = baseUrl;

new Vue({
  router,
  render: h => h(App),
  store
}).$mount("#app");
