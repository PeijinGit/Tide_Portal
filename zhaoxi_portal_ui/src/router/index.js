import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import About from '../views/About.vue'
import Recruit from '../views/Recruit.vue'
import Person from '../views/Person.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/about/',
    name: 'About',
    component: About
  }
  ,
  {
    path: '/recruit/',
    name: 'Recruit',
    component: Recruit
  }
  ,
  {
    path: '/person/',
    name: 'Person',
    component: Person
  }

]

const router = new VueRouter({
  routes
})

export default router
