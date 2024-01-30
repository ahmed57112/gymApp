import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

import mainLayoutVue from '@/layout/mainLayout.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: mainLayoutVue,
      children: [
        {
          path: '/home',
          component: HomeView,
          name: 'home',
        },
        {
          path: '/about',
          name: 'about',

          component: () => import('../views/AboutView.vue')
        }
        ,
        {
          path: '/users',
          name: 'user',

          component: () => import('../views/users/memberView.vue'),           
        },{
          path:'/addMember',
          name: 'addMember',
          component: () => import('../views/users/addUser/AddView.vue'),
        }
      ],
    },
    
  ]
})

export default router
