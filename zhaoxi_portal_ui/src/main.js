import Vue from 'vue'
import App from './App.vue'
import router from './router'
import element from 'element-ui'
import "element-ui/lib/theme-chalk/index.css"
import padTitle from "@/components/PadTitle"

Vue.config.productionTip = false
Vue.use(element);
Vue.component("padTitle",padTitle);

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
