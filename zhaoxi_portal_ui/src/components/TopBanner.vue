<template>      
  <div
    class="top-banner"
    :style="`background:url('${imgUrl}')`"
  ></div>
</template>
<script>
export default {
  props: ["imgUrl"],
};
</script>
<style lang="scss" scoped>
.top-banner {
  height: 370px;
  background-repeat: no-repeat;
  width: 100%;
  margin-top: 10px;
}
</style>