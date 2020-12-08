<template>
  <div class="pad-title">
    <h2 v-html="mTitle">
    </h2>
    <h3>
      {{ sTitle }}
    </h3>
  </div>
</template>

<script>
export default {
  props:["mTitle","sTitle"]
};
</script>

<style lang="scss" scoped>
.pad-title {
  h2 {
    height: 52px;
    text-align: center;
    font-size: 35px;
  }
  h3 {
    color: #909090;
    font-size: 22px;
    font-weight: normal;
    text-align: center;
    margin-top: 5px;
    height: 36px;
    line-height: 36px;
  }
}
</style>


