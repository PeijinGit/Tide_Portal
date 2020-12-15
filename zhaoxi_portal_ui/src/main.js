import Vue from 'vue'
import App from './App.vue'
import router from './router'
import element from 'element-ui'
import "element-ui/lib/theme-chalk/index.css"
import padTitle from "@/components/PadTitle"
import inner from "@/components/Inner"
import topBanner from "@/components/TopBanner"

Vue.config.productionTip = false
Vue.use(element);
Vue.component("padTitle",padTitle);
Vue.component("inner",inner);
Vue.component("topBanner",topBanner);

new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
